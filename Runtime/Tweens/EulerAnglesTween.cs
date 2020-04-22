using UnityEngine;

namespace UnityPackages.Tweens {
  public class EulerAnglesTween : Tween<Vector3> {
    public override Vector3 OnGetFrom () {
      return this.transform.eulerAngles;
    }

    public override void OnUpdate (float easedTime) {
      this.valueCurrent.x = Mathf.Lerp (this.valueFrom.x, this.valueTo.x, easedTime);
      this.valueCurrent.y = Mathf.Lerp (this.valueFrom.y, this.valueTo.y, easedTime);
      this.valueCurrent.z = Mathf.Lerp (this.valueFrom.z, this.valueTo.z, easedTime);
      this.transform.eulerAngles = this.valueCurrent;
    }
  }
}