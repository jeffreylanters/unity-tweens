using UnityEngine;

namespace UnityPackages.Tweens {
  public class LocalEulerAnglesZTween : Tween<float> {
    private Vector3 localEulerAngles;

    public override float OnGetFrom () {
      return this.transform.localEulerAngles.z;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      this.localEulerAngles = this.transform.localEulerAngles;
      this.valueCurrent = this.LerpValue (this.valueFrom, this.valueTo, easedTime);
      this.localEulerAngles.z = this.valueCurrent;
      this.transform.localEulerAngles = this.localEulerAngles;
    }
  }
}