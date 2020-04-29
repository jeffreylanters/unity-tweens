using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class DelayedInvokeTween {
    public static Tween<bool> TweenDelayedInvoke (this Component self, float duration, Action onComplete) =>
      self.gameObject.TweenDelayedInvoke (duration, onComplete);

    public static Tween<bool> TweenDelayedInvoke (this GameObject self, float duration, Action onComplete) =>
      self.AddComponent<Tween> ().SetOnComplete (onComplete).Finalize (duration, false);

    private class Tween : Tween<bool> {
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
