using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalRotationYTween {
    public static Tween<float> TweenLocalRotationY (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenLocalRotationY (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<float, Transform> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;

      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override float OnGetFrom () {
        return this.component.localEulerAngles.y;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.quaternionValueFrom = Quaternion.Euler (this.component.localEulerAngles.x, this.valueFrom, this.component.localEulerAngles.z);
        this.quaternionValueTo = Quaternion.Euler (this.component.localEulerAngles.x, this.valueTo, this.component.localEulerAngles.z);
        this.component.localRotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
      }
    }
  }
}