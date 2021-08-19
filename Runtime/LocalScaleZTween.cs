using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalScaleZTween {
    public static Tween<float> TweenLocalScaleZ (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenLocalScaleZ (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    private class Driver : Tween<float, Transform> {
      private Vector3 localScale;

      public override float OnGetFrom () {
        return this.component.localScale.z;
      }

      public override void OnUpdate (float easedTime) {
        this.localScale = this.component.localScale;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.localScale.z = this.valueCurrent;
        this.component.localScale = this.localScale;
      }
    }
  }
}