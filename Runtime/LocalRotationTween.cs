using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalRotationTween {
    public static Tween<Vector3> TweenLocalRotation (this Component self, Vector3 to, float duration) =>
      Tween<Vector3>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<Vector3> TweenLocalRotation (this GameObject self, Vector3 to, float duration) =>
      Tween<Vector3>.Add<Driver> (self).Finalize (to, duration);

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<Vector3, Transform> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;
      private bool didConvertValueFromToQuanternion;

      public override bool OnInitialize () {
        this.quaternionValueTo = Quaternion.Euler (this.valueTo);
        return base.OnInitialize ();
      }

      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override Vector3 OnGetFrom () {
        this.quaternionValueFrom = Quaternion.Euler (this.component.localEulerAngles);
        this.didConvertValueFromToQuanternion = true;
        return this.component.localEulerAngles;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        if (this.didConvertValueFromToQuanternion == false) {
          this.quaternionValueFrom = Quaternion.Euler (this.valueFrom);
          this.didConvertValueFromToQuanternion = true;
        }
        if (easedTime == 0)
          this.component.localRotation = this.quaternionValueFrom;
        else if (easedTime == 1)
          this.component.localRotation = this.quaternionValueTo;
        else
          this.component.localRotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
      }
    }
  }
}