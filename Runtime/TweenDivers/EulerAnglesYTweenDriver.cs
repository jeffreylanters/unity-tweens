using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class EulerAnglesYTweenDriver : TweenBase<float> {
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