using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  [AddComponentMenu ("")]
  public class EulerAnglesTweenDriver : Tween<Vector3> {
    private Quaternion quaternionValueFrom;
    private Quaternion quaternionValueTo;

    public override bool OnInitialize () {
      this.quaternionValueTo = Quaternion.Euler (this.valueTo);
      return true;
    }

    public override Vector3 OnGetFrom () {
      var _from = this.transform.eulerAngles;
      this.quaternionValueFrom = Quaternion.Euler (_from);
      return _from;
    }

    public override void OnUpdate (float easedTime) {
      if (easedTime == 0)
        this.transform.rotation = this.quaternionValueFrom;
      else if (easedTime == 1)
        this.transform.rotation = this.quaternionValueTo;
      else
        this.transform.rotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
    }
  }
}