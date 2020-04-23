using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class LocalEulerAnglesXTweenDriver : TweenMotor<float> {
    private Vector3 localEulerAngles;

    public override float OnGetFrom () {
      return this.transform.localEulerAngles.x;
    }

    public override void OnUpdate (float easedTime) {
      this.localEulerAngles = this.transform.localEulerAngles;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.localEulerAngles.x = this.valueCurrent;
      this.transform.localEulerAngles = this.localEulerAngles;
    }
  }
}