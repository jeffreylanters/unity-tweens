using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class EulerAnglesTweenDriver : TweenBase<Vector3> {
    private Quaternion quaternionValueFrom;
    private Quaternion quaternionValueTo;

    public override void OnInitialize () {
      this.quaternionValueTo = Quaternion.Euler (this.valueTo);
    }

    public override Vector3 OnGetFrom () {
      var _from = this.transform.eulerAngles;
      this.quaternionValueFrom = Quaternion.Euler (_from);
      return _from;
    }

    public override void OnUpdate (float easedTime) {
      this.transform.rotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
    }
  }
}