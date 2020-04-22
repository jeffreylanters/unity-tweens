using UnityEngine;

namespace UnityPackages.Tweens {
  public class LocalPositionZTween : Tween<float> {
    private Vector3 localPosition;

    public override float OnGetFrom () {
      return this.transform.localPosition.z;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      this.localPosition = this.transform.localPosition;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.localPosition.z = this.valueCurrent;
      this.transform.localPosition = this.localPosition;
    }
  }
}