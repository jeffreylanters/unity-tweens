using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  [AddComponentMenu ("")]
  public class PositionZTweenDriver : Tween<float> {
    private Vector3 position;

    public override bool OnInitialize () {
      return true;
    }

    public override float OnGetFrom () {
      return this.transform.position.z;
    }

    public override void OnUpdate (float easedTime) {
      this.position = this.transform.position;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.position.z = this.valueCurrent;
      this.transform.position = this.position;
    }
  }
}