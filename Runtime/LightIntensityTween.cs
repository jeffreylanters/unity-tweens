using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LightIntensityTween {
    public static Tween<float> TweenLightIntensity (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenLightIntensity (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float, Light> {
      public override float OnGetFrom () {
        return this.component.intensity;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.intensity = this.valueCurrent;
      }
    }
  }
}