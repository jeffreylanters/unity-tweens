using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class DelayedInvokeTween {
    public static Tween<bool> TweenDelayedInvoke (this Component self, bool to, float duration) =>
      self.gameObject.TweenDelayedInvoke (duration, to);

    public static Tween<bool> TweenDelayedInvoke (this GameObject self, bool to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

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
