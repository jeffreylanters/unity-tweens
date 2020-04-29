using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalEulerAnglesTween {
    public static Tween<Vector3> TweenLocalRotation (this Component self, Vector3 to, float duration) =>
      self.gameObject.TweenLocalRotation (to, duration);

    public static Tween<Vector3> TweenLocalRotation (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<Vector3> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;

      public override bool OnInitialize () {
        this.quaternionValueTo = Quaternion.Euler (this.valueTo);
        return true;
      }

      public override Vector3 OnGetFrom () {
        var _from = this.transform.localEulerAngles;
        this.quaternionValueFrom = Quaternion.Euler (_from);
        return _from;
      }

      public override void OnUpdate (float easedTime) {
        if (easedTime == 0)
          this.transform.localRotation = this.quaternionValueFrom;
        else if (easedTime == 1)
          this.transform.localRotation = this.quaternionValueTo;
        else
          this.transform.localRotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
      }
    }
  }
}