using UnityEngine;
using Tweens.Core;

namespace Tweens {
  public abstract class TweenInstance {
    internal readonly float duration;
    internal readonly float? pingPongInterval;
    internal readonly float? repeatInterval;
    internal readonly bool useUnscaledTime;
    internal readonly bool usePingPong;
    internal readonly FillMode fillMode = FillMode.Backwards;
    internal float? delay;
    internal int? loops;
    internal bool isDecommissioned;
    internal float time;
    internal bool isForwards = true;
    internal bool didReachEnd;
    internal EaseFunctionDelegate easeFunction;
    internal OnCancelDelegate onCancel;
    public readonly GameObject target;
    public bool isPaused;

    internal abstract void Update();
    public abstract void Cancel();

    internal TweenInstance(GameObject target, Tween tween) {
      this.target = target;
      duration = tween.duration > 0 ? tween.duration : 0.001f;
      pingPongInterval = tween.pingPongInterval;
      repeatInterval = tween.repeatInterval;
      useUnscaledTime = tween.useUnscaledTime;
      usePingPong = tween.usePingPong;
      fillMode = tween.fillMode;
    }
  }

  public class TweenInstance<ComponentType, DataType> : TweenInstance where ComponentType : Component {
    readonly ComponentType component;
    OnStartDelegate<ComponentType, DataType> onStart;
    readonly OnUpdateDelegate<ComponentType, DataType> onUpdate;
    OnEndDelegate<ComponentType, DataType> onEnd;
    readonly ApplyDelegate<ComponentType, DataType> apply;
    readonly LerpDelegate<DataType> lerp;
    readonly DataType initial;
    readonly DataType from;
    readonly DataType to;

    internal TweenInstance(GameObject target, Tween<ComponentType, DataType> tween) : base(target, tween) {
      component = target.GetComponent<ComponentType>();
      initial = tween.Current(component);
      from = tween.from != null ? tween.from : tween.Current(component);
      to = tween.to != null ? tween.to : tween.Current(component);
      onStart = tween.onStart;
      onEnd = tween.onEnd;
      onCancel = tween.onCancel;
      delay = tween.delay;
      loops = tween.isInfinite ? -1 : tween.loops;
      onUpdate = tween.onUpdate;
      apply = tween.Apply;
      lerp = tween.Lerp;
      easeFunction = tween.animationCurve != null ? new AnimationCurve(tween.animationCurve.keys).Evaluate : EaseFunctions.GetFunction(tween.easeType);
      if (delay > 0 && (fillMode == FillMode.Both || fillMode == FillMode.Forwards)) {
        apply(component, from);
        onUpdate?.Invoke(this, from);
      }
      Debug.Log($"Tween on {target.name} is added on frame {Time.frameCount}");
    }

    internal sealed override void Update() {
      Debug.Log($"Tween on {target.name} is updated on frame {Time.frameCount}");
      if (component == null) {
        Cancel();
        return;
      }
      if (isPaused) {
        return;
      }
      var deltaTime = useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
      if (delay.HasValue) {
        delay -= deltaTime;
        if (delay <= 0) {
          delay = null;
        }
        else {
          return;
        }
      }
      if (onStart != null) {
        onStart.Invoke(this);
        onStart = null;
      }
      var timeStep = deltaTime / duration;
      time += isForwards ? timeStep : -timeStep;
      if (time >= 1) {
        time = 1;
        if (usePingPong) {
          isForwards = false;
          delay = pingPongInterval ?? delay;
        }
        else {
          didReachEnd = true;
          delay = repeatInterval ?? delay;
        }
      }
      else if (usePingPong && time < 0) {
        time = 0;
        isForwards = true;
        didReachEnd = true;
        delay = repeatInterval ?? delay;
      }
      var easedTime = easeFunction(time);
      var value = lerp(from, to, easedTime);
      apply(component, value);
      onUpdate?.Invoke(this, value);
      if (didReachEnd) {
        if (loops > 1 || loops == -1) {
          didReachEnd = false;
          time = 0;
          if (loops > 1) {
            loops -= 1;
          }
        }
        else {
          if (fillMode == FillMode.Forwards || fillMode == FillMode.None) {
            apply(component, initial);
            onUpdate?.Invoke(this, initial);
          }
          onEnd?.Invoke(this);
          isDecommissioned = true;
        }
      }
    }

    public sealed override void Cancel() {
      if (onCancel != null) {
        onCancel.Invoke();
        onCancel = null;
      }
      isDecommissioned = true;
    }
  }
}