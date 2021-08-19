using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class PositionYTween {
    public static Tween<float> TweenPositionY (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenPositionY (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<float, Transform> {
      private Vector3 position;

      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override float OnGetFrom () {
        return this.component.position.y;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.position = this.component.position;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.position.y = this.valueCurrent;
        this.component.position = this.position;
      }
    }
  }
}