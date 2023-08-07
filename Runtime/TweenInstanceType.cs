using System;
using Tweens.Core.Data;
using Tweens.Core;
using UnityEngine;

namespace Tweens {
  public class TweenInstance<ComponentType, DataType> : TweenInstance {
    readonly ComponentType component;
    readonly DataType from;
    readonly DataType to;
    readonly Action<ComponentType, DataType> apply;
    readonly Func<DataType, DataType, float, DataType> lerp;
    readonly SetValue<Action<TweenInstance<ComponentType, DataType>, DataType>> onUpdate = new();
    internal SetValue<Action<TweenInstance<ComponentType, DataType>>> onEnd;
    internal CompletableValue<Action<TweenInstance<ComponentType, DataType>>> onStart;
    internal CompletableValue<Action<TweenInstance<ComponentType, DataType>>> onCancel;

    internal TweenInstance(GameObject target, Tween<ComponentType, DataType> tween) : base(target) {
      component = target.GetComponent<ComponentType>();
      from = tween.from.HasValue ? tween.from : tween.From(component);
      to = tween.to;
      duration = tween.duration > 0 ? tween.duration : 0.001f;
      onStart = tween.onStart.HasValue ? new(tween.onStart) : new();
      onEnd = tween.onEnd.HasValue ? new(tween.onEnd) : new();
      onCancel = tween.onCancel.HasValue ? new(tween.onCancel) : new();
      useScaledTime = tween.useScaledTime;
      delay = tween.delay.HasValue ? new(tween.delay) : new();
      easeType = tween.easeType;
      loops = tween.loops.HasValue ? new(tween.loops) : new();
      onUpdate = tween.onUpdate.HasValue ? new(tween.onUpdate) : new();
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
          delay.Unset();
        }
        return;
      }
      if (onStart.HasValue && !onStart.DidComplete) {
        onStart.Value.Invoke(this);
        onStart.Complete();
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
      if (onUpdate.HasValue) {
        onUpdate.Value.Invoke(this, value);
      }
      if (didReachEnd) {
        if (loops.HasValue && loops > 1) {
          didReachEnd = false;
          loops -= 1;
          time = 0;
        }
        else {
          if (onEnd.HasValue) {
            onEnd.Value.Invoke(this);
          }
          Cleanup();
        }
      }
    }

    public sealed override void Cancel() {
      if (onCancel.HasValue && !onCancel.DidComplete) {
        onCancel.Value.Invoke(this);
        onCancel.Complete();
      }
      Cleanup();
    }
  }
}