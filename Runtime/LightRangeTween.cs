using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LightRangeTween {

    /// <summary>
    /// Instantiates a tween which changes the <see cref="Light"/>'s range over
    /// time. The Light range is only avaiable on Spot, Point and Area Lights.
    /// </summary>
    /// <param name="self">The target Component.</param>
    /// <param name="to">The target value.</param>
    /// <param name="duration">The Tween's duration.</param>
    /// <returns>A Tween.</returns>
    public static Tween<float> TweenLightRange (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    /// <summary>
    /// Instantiates a tween which changes the <see cref="Light"/>'s range over
    /// time. The Light range is only avaiable on Spot, Point and Area Lights.
    /// </summary>
    /// <param name="self">The target GameObject.</param>
    /// <param name="to">The target value.</param>
    /// <param name="duration">The Tween's duration.</param>
    /// <returns>A Tween.</returns>
    public static Tween<float> TweenLightRange (this GameObject self, float to, float duration) =>
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
        return this.component.range;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.range = this.valueCurrent;
      }
    }
  }
}