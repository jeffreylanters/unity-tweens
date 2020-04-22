using UnityEngine;

namespace UnityPackages.Tweens {
  public class LocalEulerAnglesYTween : Tween<float> {
    private Vector3 localEulerAngles;

    public override float OnGetFrom () {
      return this.transform.localEulerAngles.y;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      this.localEulerAngles = this.transform.localEulerAngles;
      this.valueCurrent = this.LerpValue (this.valueFrom, this.valueTo, easedTime);
      this.localEulerAngles.y = this.valueCurrent;
      this.transform.localEulerAngles = this.localEulerAngles;
    }
  }
}