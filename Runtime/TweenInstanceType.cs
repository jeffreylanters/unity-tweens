using System;
using Tweens.Core;
using UnityEngine;

namespace Tweens {
  public class TweenInstance<ComponentType, DataType> : TweenInstance {
    readonly ComponentType component;
    readonly DataType from;
    readonly DataType to;
    readonly Action<ComponentType, DataType> apply; // TODO -- make this a delegate
    readonly Func<DataType, DataType, float, DataType> lerp; // TODO -- make this a delegate
    internal Action<TweenInstance<ComponentType, DataType>> onStart; // TODO -- make this a delegate
    readonly Action<TweenInstance<ComponentType, DataType>, DataType> onUpdate; // TODO -- make this a delegate
    internal Action<TweenInstance<ComponentType, DataType>> onEnd; // TODO -- make this a delegate
    internal Action onCancel; // TODO -- make this a delegate

    internal TweenInstance(GameObject target, Tween<ComponentType, DataType> tween) : base(target) {
      component = target.GetComponent<ComponentType>();
      from = tween.from != null ? tween.from : tween.Current(component);
      to = tween.to != null ? tween.to : tween.Current(component);
      duration = tween.duration > 0 ? tween.duration : 0.001f;
      onStart = tween.onStart;
      onEnd = tween.onEnd;
      onCancel = tween.onCancel;
      useScaledTime = tween.useScaledTime;
      delay = tween.delay;
      easeType = tween.easeType;
      loops = tween.loops;
      onUpdate = tween.onUpdate;
      usePingPong = tween.usePingPong;
      isInfinite = tween.isInfinite;
      apply = tween.Apply;
      lerp = tween.Lerp;
      if (tween.prewarm && delay.HasValue) {
        apply(component, lerp(from, to, 0));
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
      var easedTime = MathHelper.EaseTime(easeType, time);
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