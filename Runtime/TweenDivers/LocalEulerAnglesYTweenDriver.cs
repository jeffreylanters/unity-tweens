using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class LocalEulerAnglesYTweenDriver : TweenBase<float> {
    private Vector3 localEulerAngles;

    public override void OnInitialize () {
      this.valueTo = this.WrapAngle (this.valueTo);
    }

    public override float OnGetFrom () {
      return this.transform.localEulerAngles.y;
    }

    public override void OnUpdate (float easedTime) {
      this.localEulerAngles = this.transform.localEulerAngles;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.localEulerAngles.y = this.valueCurrent;
      this.transform.localEulerAngles = this.localEulerAngles;
    }
  }
}