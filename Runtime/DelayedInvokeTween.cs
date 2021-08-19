using System;
using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class DelayedInvokeTween {
    [ObsoleteAttribute ("This method is deprecated, Unity Tweens will only focus on actual Tweens in the future. Please implement another way of invoke in method delayed.")]
    public static Tween<bool> TweenDelayedInvoke (this Component self, float duration, Action onComplete) =>
      Tween<bool>.Add<Driver> (self).SetOnComplete (onComplete).Finalize (false, duration);

    [ObsoleteAttribute ("This method is deprecated, Unity Tweens will only focus on actual Tweens in the future. Please implement another way of invoke in method delayed.")]
    public static Tween<bool> TweenDelayedInvoke (this GameObject self, float duration, Action onComplete) =>
      Tween<bool>.Add<Driver> (self).SetOnComplete (onComplete).Finalize (false, duration);

    private class Driver : Tween<bool> {
      public override bool OnInitialize () {
        return true;
      }

      public override bool OnGetFrom () {
        return true;
      }

      public override void OnUpdate (float easedTime) { }
    }
  }
}