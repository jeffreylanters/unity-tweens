using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class EulerAnglesYTweenDriver : TweenBase<float> {
    private Vector3 eulerAngles;

    public override float OnGetFrom () {
      return this.transform.eulerAngles.y;
    }

    public override void OnUpdate (float easedTime) {
      this.eulerAngles = this.transform.eulerAngles;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.eulerAngles.y = this.valueCurrent;
      this.transform.eulerAngles = this.eulerAngles;
    }
  }
}