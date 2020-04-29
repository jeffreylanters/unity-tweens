using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalEulerAnglesXTween {
    public static Tween<float> TweenLocalEulerAnglesX (this Component self, float to, float duration) =>
      self.gameObject.TweenLocalEulerAnglesX (to, duration);

    public static Tween<float> TweenLocalEulerAnglesX (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.localEulerAngles.x;
      }

      public override void OnUpdate (float easedTime) {
        this.quaternionValueFrom = Quaternion.Euler (this.valueFrom, this.transform.localEulerAngles.y, this.transform.localEulerAngles.z);
        this.quaternionValueTo = Quaternion.Euler (this.valueTo, this.transform.localEulerAngles.y, this.transform.localEulerAngles.z);
        this.transform.localRotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
      }
    }
  }
}