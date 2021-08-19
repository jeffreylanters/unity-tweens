using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class CameraFieldOfViewTween {
    public static Tween<float> TweenCameraFieldOfView (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenCameraFieldOfView (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    private class Driver : Tween<float, Camera> {
      public override float OnGetFrom () {
        return this.component.fieldOfView;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.fieldOfView = this.valueCurrent;
      }
    }
  }
}