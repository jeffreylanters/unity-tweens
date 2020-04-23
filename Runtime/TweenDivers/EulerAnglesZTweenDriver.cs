using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class EulerAnglesZTweenDriver : TweenBase<float> {
    private Vector3 eulerAngles;

    public override void OnInitialize () {
      this.valueTo = this.WrapAngle (this.valueTo);
    }

    public override float OnGetFrom () {
      return this.transform.eulerAngles.z;
    }

    public override void OnUpdate (float easedTime) {
      this.eulerAngles = this.transform.eulerAngles;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.eulerAngles.z = this.valueCurrent;
      this.transform.eulerAngles = this.eulerAngles;
    }
  }
}