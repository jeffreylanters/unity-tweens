using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class EulerAnglesYTween {
    public static Tween<float> TweenEulerAnglesY (this Component self, float to, float duration) =>
      self.gameObject.TweenEulerAnglesY (to, duration);

    public static Tween<float> TweenEulerAnglesY (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.eulerAngles.y;
      }

      public override void OnUpdate (float easedTime) {
        this.quaternionValueFrom = Quaternion.Euler (this.transform.eulerAngles.x, this.valueFrom, this.transform.eulerAngles.z);
        this.quaternionValueTo = Quaternion.Euler (this.transform.eulerAngles.x, this.valueTo, this.transform.eulerAngles.z);
        this.transform.rotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
      }
    }
  }
}