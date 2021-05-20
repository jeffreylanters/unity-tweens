using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalEulerAnglesTween {
    public static Tween<Vector3> TweenLocalRotation (this Component self, Vector3 to, float duration) =>
      Tween<Vector3>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<Vector3> TweenLocalRotation (this GameObject self, Vector3 to, float duration) =>
      Tween<Vector3>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<Vector3, Transform> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;

      public override bool OnInitialize () {
        this.quaternionValueTo = Quaternion.Euler (this.valueTo);
        return base.OnInitialize ();
      }

      public override Vector3 OnGetFrom () {
        var _from = this.component.localEulerAngles;
        this.quaternionValueFrom = Quaternion.Euler (_from);
        return _from;
      }

      public override void OnUpdate (float easedTime) {
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