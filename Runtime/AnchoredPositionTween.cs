using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class AnchoredPositionTween {
    public static Tween<Vector2, RectTransform> TweenAnchoredPosition (this Component self, Vector2 to, float duration) =>
      Tween<Vector2, RectTransform>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<Vector2, RectTransform> TweenAnchoredPosition (this GameObject self, Vector2 to, float duration) =>
      Tween<Vector2, RectTransform>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<Vector2, RectTransform> {
      public override Vector2 OnGetFrom => this.component.anchoredPosition;

      public override void OnUpdate (float easedTime) {
        this.valueCurrent.x = this.InterpolateValue (this.valueFrom.x, this.valueTo.x, easedTime);
        this.valueCurrent.y = this.InterpolateValue (this.valueFrom.y, this.valueTo.y, easedTime);
        this.component.anchoredPosition = this.valueCurrent;
      }
    }
  }
}