using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalRotationXTween {
    public static Tween<float> TweenLocalRotationX (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenLocalRotationX (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    private class Driver : Tween<float, Transform> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;

      public override float OnGetFrom () {
        return this.component.localEulerAngles.x;
      }

      public override void OnUpdate (float easedTime) {
        this.quaternionValueFrom = Quaternion.Euler (this.valueFrom, this.component.localEulerAngles.y, this.component.localEulerAngles.z);
        this.quaternionValueTo = Quaternion.Euler (this.valueTo, this.component.localEulerAngles.y, this.component.localEulerAngles.z);
        this.component.localRotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
      }
    }
  }
}