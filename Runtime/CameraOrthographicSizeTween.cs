using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class CameraOrthographicSizeTween {
    public static Tween<float> TweenCameraOrthographicSize (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenCameraOrthographicSize (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float> {
      private new Camera camera;

      public override bool OnInitialize () {
        this.camera = this.gameObject.GetComponent<Camera> ();
        return this.camera != null;
      }

      public override float OnGetFrom () {
        return this.camera.orthographicSize;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.camera.orthographicSize = this.valueCurrent;
      }
    }
  }
}