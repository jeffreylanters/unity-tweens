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

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<bool> {
      public override bool OnInitialize () {
        return true;
      }

      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override bool OnGetFrom () {
        return true;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) { }
    }
  }
}