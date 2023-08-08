using System.Threading;
using UnityEngine;
using Tweens.Core;
using System;

namespace Tweens {
  public abstract class TweenInstance {
    internal float duration;
    internal float? delay;
    internal bool useScaledTime = true;
    internal bool usePingPong;
    internal bool isInfinite;
    internal int? loops;
    internal FillMode fillMode = FillMode.Backwards;
    public GameObject target;
    public bool isPaused;
    internal float time;
    internal bool isForwards = true;
    internal bool didReachEnd;
    internal CancellationTokenSource cancellationTokenSource = new();
    internal CancellationToken cancellationToken;
    internal Func<float, float> easeFunction;
    internal Action onCancel; // TODO -- make this a delegate

    internal abstract void Update();
    public abstract void Cancel();

    internal TweenInstance(GameObject target) {
      this.target = target;
      cancellationToken = cancellationTokenSource.Token;
    }

    internal void Cleanup() {
      cancellationTokenSource.Cancel();
      TweenEngine.Remove(this);
    }
  }

  public class TweenInstance<ComponentType, DataType> : TweenInstance where ComponentType : Component {
    internal DataType initial;
    internal DataType from;
    internal DataType to;
    internal Action<TweenInstance<ComponentType, DataType>> onStart; // TODO -- make this a delegate
    internal Action<TweenInstance<ComponentType, DataType>, DataType> onUpdate; // TODO -- make this a delegate
    internal Action<TweenInstance<ComponentType, DataType>> onEnd; // TODO -- make this a delegate
    readonly ComponentType component;
    readonly Action<ComponentType, DataType> apply; // TODO -- make this a delegate
    readonly Func<DataType, DataType, float, DataType> lerp; // TODO -- make this a delegate

    internal TweenInstance(GameObject target, Tween<ComponentType, DataType> tween) : base(target) {
      component = target.GetComponent<ComponentType>();
      initial = tween.Current(component);
      from = tween.from != null ? tween.from : tween.Current(component);
      to = tween.to != null ? tween.to : tween.Current(component);
      duration = tween.duration > 0 ? tween.duration : 0.001f;
      onStart = tween.onStart;
      onEnd = tween.onEnd;
      onCancel = tween.onCancel;
      useScaledTime = tween.useScaledTime;
      delay = tween.delay;
      loops = tween.loops;
      onUpdate = tween.onUpdate;
      usePingPong = tween.usePingPong;
      isInfinite = tween.isInfinite;
      apply = tween.Apply;
      lerp = tween.Lerp;
      fillMode = tween.fillMode;
      easeFunction = EaseFunctions.GetFunction(tween.easeType);
      if (fillMode == FillMode.Both || fillMode == FillMode.Forwards) {
        apply(component, from);
      }
    }

    internal sealed override void Update() {
      if (isPaused) {
        return;
      }
      var deltaTime = useScaledTime ? Time.deltaTime : Time.unscaledDeltaTime;
      if (delay.HasValue) {
        delay -= deltaTime;
        if (delay <= 0) {
          delay = null;
        }
        return;
      }
      if (onStart != null) {
        onStart!.Invoke(this);
        onStart = null;
      }
      var timeStep = deltaTime / duration;
      time += isForwards ? timeStep : -timeStep;
      if (time >= 1) {
        time = 1;
        if (usePingPong) {
          isForwards = false;
        }
        else if (!isInfinite) {
          didReachEnd = true;
        }
        else {
          time = 0;
        }
      }
      else if (usePingPong && time < 0) {
        time = 0;
        isForwards = true;
        if (!isInfinite) {
          didReachEnd = true;
        }
      }
      var easedTime = easeFunction(time);
      var value = lerp(from, to, easedTime);
      apply(component, value);
      if (onUpdate != null) {
        onUpdate!.Invoke(this, value);
      }
      if (didReachEnd) {
        if (loops.HasValue && loops > 1) {
          didReachEnd = false;
          loops -= 1;
          time = 0;
        }
        else {
          if (onEnd != null) {
            onEnd!.Invoke(this);
            onEnd = null;
          }
          if (fillMode == FillMode.Forwards || fillMode == FillMode.None) {
            apply(component, initial);
          }
          else if (fillMode == FillMode.Both) {
            apply(component, to);
          }
          Cleanup();
        }
      }
    }

    public sealed override void Cancel() {
      if (onCancel != null) {
        onCancel!.Invoke();
        onCancel = null;
      }
      Cleanup();
    }
  }
}