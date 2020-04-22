using UnityEngine;

namespace UnityPackages.Tweens {
  public class LocalScaleZTween : Tween<float> {
    private Vector3 localScale;

    public override float OnGetFrom () {
      return this.transform.localScale.z;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      this.localScale = this.transform.localScale;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.localScale.z = this.valueCurrent;
      this.transform.localScale = this.localScale;
    }
  }
}