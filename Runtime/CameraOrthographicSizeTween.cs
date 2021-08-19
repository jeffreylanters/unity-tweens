using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class CameraOrthographicSizeTween {
    public static Tween<float> TweenCameraOrthographicSize (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenCameraOrthographicSize (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    private class Driver : Tween<float, Camera> {
      public override float OnGetFrom () {
        return this.component.orthographicSize;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.orthographicSize = this.valueCurrent;
      }
    }
  }
}