using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class AnchoredPositionTween {
    public static Tween<Vector2> TweenAnchoredPosition (this Component self, Vector2 to, float duration) =>
      self.gameObject.TweenAnchoredPosition (to, duration);

    public static Tween<Vector2> TweenAnchoredPosition (this GameObject self, Vector2 to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<Vector2> {
      private RectTransform rectTransform;

      public override bool OnInitialize () {
        this.rectTransform = this.gameObject.GetComponent<RectTransform> ();
        return this.rectTransform != null;
      }

      public override Vector2 OnGetFrom () {
        return this.rectTransform.anchoredPosition;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent.x = this.InterpolateValue (this.valueFrom.x, this.valueTo.x, easedTime);
        this.valueCurrent.y = this.InterpolateValue (this.valueFrom.y, this.valueTo.y, easedTime);
        this.rectTransform.anchoredPosition = this.valueCurrent;
      }
    }
  }
}