using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class EulerAnglesZTween {
    public static Tween<float> TweenRotationZ (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenRotationZ (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float, Transform> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;

      public override float OnGetFrom () {
        return this.component.eulerAngles.z;
      }

      public override void OnUpdate (float easedTime) {
        this.quaternionValueFrom = Quaternion.Euler (this.component.eulerAngles.x, this.component.eulerAngles.y, this.valueFrom);
        this.quaternionValueTo = Quaternion.Euler (this.component.eulerAngles.x, this.component.eulerAngles.y, this.valueTo);
        this.component.rotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
      }
    }
  }
}