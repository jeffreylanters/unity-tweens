using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LightIntensityTween {
    public static Tween<float> TweenLightIntensity (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenLightIntensity (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<float, Light> {

      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override float OnGetFrom () {
        return this.component.intensity;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.intensity = this.valueCurrent;
      }
    }
  }
}