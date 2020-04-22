using UnityEngine;

namespace UnityPackages.Tweens {
  public class LocalPositionXTween : Tween<float> {
    private Vector3 localPosition;

    public override float OnGetFrom () {
      return this.transform.localPosition.x;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      this.localPosition = this.transform.localPosition;
      this.valueCurrent = Mathf.Lerp (this.valueFrom, this.valueTo, easedTime);
      this.localPosition.x = this.valueCurrent;
      this.transform.localPosition = this.localPosition;
    }
  }
}