using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalPositionZTween {
    public static Tween<float> TweenLocalPositionZ (this Component self, float to, float duration) =>
      self.gameObject.TweenLocalPositionZ (to, duration);

    public static Tween<float> TweenLocalPositionZ (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Vector3 localPosition;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.localPosition.z;
      }

      public override void OnUpdate (float easedTime) {
        this.localPosition = this.transform.localPosition;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.localPosition.z = this.valueCurrent;
        this.transform.localPosition = this.localPosition;
      }
    }
  }
}