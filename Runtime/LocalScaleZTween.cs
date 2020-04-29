using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalScaleZTween {
    public static Tween<float> TweenLocalScaleZ (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenLocalScaleZ (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float> {
      private Vector3 localScale;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.localScale.z;
      }

      public override void OnUpdate (float easedTime) {
        this.localScale = this.transform.localScale;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.localScale.z = this.valueCurrent;
        this.transform.localScale = this.localScale;
      }
    }
  }
}