using UnityEngine;

namespace UnityPackages.Tweens {
  public class LocalPositionYTween : Tween<float> {
    private Vector3 localPosition;

    public override float OnGetFrom () {
      return this.transform.localPosition.y;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      this.localPosition = this.transform.localPosition;
      this.valueCurrent = Mathf.Lerp (this.valueFrom, this.valueTo, easedTime);
      this.localPosition.y = this.valueCurrent;
      this.transform.localPosition = this.localPosition;
    }
  }
}