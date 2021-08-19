using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalPositionXTween {
    public static Tween<float> TweenLocalPositionX (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenLocalPositionX (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    private class Driver : Tween<float, Transform> {
      private Vector3 localPosition;

      public override float OnGetFrom () {
        return this.component.localPosition.x;
      }

      public override void OnUpdate (float easedTime) {
        this.localPosition = this.component.localPosition;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.localPosition.x = this.valueCurrent;
        this.component.localPosition = this.localPosition;
      }
    }
  }
}