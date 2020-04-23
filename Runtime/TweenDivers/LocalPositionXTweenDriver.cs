using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class LocalPositionXTweenDriver : TweenBase<float> {
    private Vector3 localPosition;

    public override void OnInitialize () { }

    public override float OnGetFrom () {
      return this.transform.localPosition.x;
    }

    public override void OnUpdate (float easedTime) {
      this.localPosition = this.transform.localPosition;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.localPosition.x = this.valueCurrent;
      this.transform.localPosition = this.localPosition;
    }
  }
}