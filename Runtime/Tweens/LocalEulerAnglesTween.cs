using UnityEngine;

namespace UnityPackages.Tweens {
  public class LocalEulerAnglesTween : Tween<Vector3> {
    public override Vector3 OnGetFrom () {
      return this.transform.localEulerAngles;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      this.valueCurrent.x = this.InterpolateValue (this.valueFrom.x, this.valueTo.x, easedTime);
      this.valueCurrent.y = this.InterpolateValue (this.valueFrom.y, this.valueTo.y, easedTime);
      this.valueCurrent.z = this.InterpolateValue (this.valueFrom.z, this.valueTo.z, easedTime);
      this.transform.localEulerAngles = this.valueCurrent;
    }
  }
}