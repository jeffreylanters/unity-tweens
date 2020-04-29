using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class EulerAnglesXTween {
    public static Tween<float> TweenEulerAnglesX (this Component self, float to, float duration) =>
      self.gameObject.TweenEulerAnglesX (to, duration);

    public static Tween<float> TweenEulerAnglesX (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.eulerAngles.x;
      }

      public override void OnUpdate (float easedTime) {
        this.quaternionValueFrom = Quaternion.Euler (this.valueFrom, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
        this.quaternionValueTo = Quaternion.Euler (this.valueTo, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
        this.transform.rotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
      }
    }
  }
}