using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class PositionTweenDriver : TweenBase<Vector3> {
    public override bool OnInitialize () {
      return true;
    }

    public override Vector3 OnGetFrom () {
      return this.transform.position;
    }

    public override void OnUpdate (float easedTime) {
      this.valueCurrent.x = this.InterpolateValue (this.valueFrom.x, this.valueTo.x, easedTime);
      this.valueCurrent.y = this.InterpolateValue (this.valueFrom.y, this.valueTo.y, easedTime);
      this.valueCurrent.z = this.InterpolateValue (this.valueFrom.z, this.valueTo.z, easedTime);
      this.transform.position = this.valueCurrent;
    }
  }
}