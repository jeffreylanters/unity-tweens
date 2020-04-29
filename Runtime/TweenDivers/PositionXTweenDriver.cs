using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  [AddComponentMenu ("")]
  public class PositionXTweenDriver : TweenDriver<float> {
    private Vector3 position;

    public override bool OnInitialize () {
      return true;
    }

    public override float OnGetFrom () {
      return this.transform.position.x;
    }

    public override void OnUpdate (float easedTime) {
      this.position = this.transform.position;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.position.x = this.valueCurrent;
      this.transform.position = this.position;
    }
  }
}