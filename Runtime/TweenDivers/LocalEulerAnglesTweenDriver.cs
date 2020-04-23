using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class LocalEulerAnglesTweenDriver : TweenBase<Vector3> {
    public override void OnInitialize () {
      this.valueTo.x = this.WrapAngle (this.valueTo.x);
      this.valueTo.y = this.WrapAngle (this.valueTo.y);
      this.valueTo.z = this.WrapAngle (this.valueTo.z);
    }

    public override Vector3 OnGetFrom () {
      return this.transform.localEulerAngles;
    }

    public override void OnUpdate (float easedTime) {
      this.valueCurrent.x = this.InterpolateValue (this.valueFrom.x, this.valueTo.x, easedTime);
      this.valueCurrent.y = this.InterpolateValue (this.valueFrom.y, this.valueTo.y, easedTime);
      this.valueCurrent.z = this.InterpolateValue (this.valueFrom.z, this.valueTo.z, easedTime);
      this.transform.localEulerAngles = this.valueCurrent;
    }
  }
}