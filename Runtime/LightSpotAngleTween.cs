using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LightSpotAngleTween {

    /// <summary>
    /// Instantiates a tween which changes the <see cref="Light"/>'s spot angle
    /// over time. The spot angle is only available on spot lights.
    /// </summary>
    /// <param name="self">The target Component.</param>
    /// <param name="to">The target value.</param>
    /// <param name="duration">The Tween's duration.</param>
    /// <returns>A Tween.</returns>
    public static Tween<float> TweenLightSpotAngle (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    /// <summary>
    /// Instantiates a tween which changes the <see cref="Light"/>'s spot angle
    /// over time. The spot angle is only available on spot lights.
    /// </summary>
    /// <param name="self">The target GameObject.</param>
    /// <param name="to">The target value.</param>
    /// <param name="duration">The Tween's duration.</param>
    /// <returns>A Tween.</returns>
    public static Tween<float> TweenLightSpotAngle (this GameObject self, float to, float duration) =>
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
        return this.component.spotAngle;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.spotAngle = this.valueCurrent;
      }
    }
  }
}