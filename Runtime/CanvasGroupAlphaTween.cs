using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class CanvasGroupAlphaTween {
    public static Tween<float> TweenCanvasGroupAlpha (this Component self, float to, float duration) =>
      self.gameObject.TweenCanvasGroupAlpha (to, duration);

    public static Tween<float> TweenCanvasGroupAlpha (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private CanvasGroup canvasGroup;

      public override bool OnInitialize () {
        this.canvasGroup = this.gameObject.GetComponent<CanvasGroup> ();
        return this.canvasGroup != null;
      }

      public override float OnGetFrom () {
        return this.canvasGroup.alpha;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.canvasGroup.alpha = this.valueCurrent;
      }
    }
  }
}