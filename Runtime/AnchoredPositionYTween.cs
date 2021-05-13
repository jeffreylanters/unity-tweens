using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class AnchoredPositionYTween {
    public static Tween<float> TweenAnchoredPositionY (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenAnchoredPositionY (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float, RectTransform> {
      private Vector2 vector2Allocation;

      public override float OnGetFrom () => 
        this.component.anchoredPosition.y;

      public override void OnUpdate (float easedTime) {
        this.vector2Allocation = this.component.anchoredPosition;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.vector2Allocation.y = this.valueCurrent;
        this.component.anchoredPosition = this.vector2Allocation;
      }
    }
  }
}