using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class EulerAnglesZTween {
    public static Tween<float> TweenRotationZ (this Component self, float to, float duration) =>
      self.gameObject.TweenRotationZ (to, duration);

    public static Tween<float> TweenRotationZ (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Quaternion quaternionValueFrom;
      private Quaternion quaternionValueTo;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.eulerAngles.z;
      }

      public override void OnUpdate (float easedTime) {
        this.quaternionValueFrom = Quaternion.Euler (this.transform.eulerAngles.x, this.transform.eulerAngles.y, this.valueFrom);
        this.quaternionValueTo = Quaternion.Euler (this.transform.eulerAngles.x, this.transform.eulerAngles.y, this.valueTo);
        this.transform.rotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
      }
    }
  }
}