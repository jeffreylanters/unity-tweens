using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.Core.Drivers {
  [AddComponentMenu ("")]
  public class EulerAnglesXTween : Tween<float> {
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