using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class LocalEulerAnglesYTweenDriver : TweenBase<float> {
    private Quaternion quaternionValueFrom;
    private Quaternion quaternionValueTo;

    public override bool OnInitialize () {
      return true;
    }

    public override float OnGetFrom () {
      return this.transform.localEulerAngles.y;
    }

    public override void OnUpdate (float easedTime) {
      this.quaternionValueFrom = Quaternion.Euler (this.transform.localEulerAngles.x, this.valueFrom, this.transform.localEulerAngles.z);
      this.quaternionValueTo = Quaternion.Euler (this.transform.localEulerAngles.x, this.valueTo, this.transform.localEulerAngles.z);
      this.transform.localRotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
    }
  }
}