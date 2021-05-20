using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalPositionZTween {
    public static Tween<float> TweenLocalPositionZ (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenLocalPositionZ (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float, Transform> {
      private Vector3 localPosition;

      public override float OnGetFrom () {
        return this.component.localPosition.z;
      }

      public override void OnUpdate (float easedTime) {
        this.localPosition = this.component.localPosition;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.localPosition.z = this.valueCurrent;
        this.component.localPosition = this.localPosition;
      }
    }
  }
}