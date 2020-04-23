using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class LocalEulerAnglesTweenDriver : TweenBase<Vector3> {
    private Quaternion quaternionValueFrom;
    private Quaternion quaternionValueTo;

    public override void OnInitialize () {
      this.quaternionValueTo = Quaternion.Euler (this.valueTo);
    }

    public override Vector3 OnGetFrom () {
      var _from = this.transform.localEulerAngles;
      this.quaternionValueFrom = Quaternion.Euler (_from);
      return _from;
    }

    public override void OnUpdate (float easedTime) {
      this.transform.localRotation = Quaternion.Lerp (this.quaternionValueFrom, this.quaternionValueTo, easedTime);
    }
  }
}