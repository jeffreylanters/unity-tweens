using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalPositionYTween {
    public static Tween<float> TweenLocalPositionY (this Component self, float to, float duration) =>
      self.gameObject.TweenLocalPositionY (to, duration);

    public static Tween<float> TweenLocalPositionY (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Vector3 localPosition;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.localPosition.y;
      }

      public override void OnUpdate (float easedTime) {
        this.localPosition = this.transform.localPosition;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.localPosition.y = this.valueCurrent;
        this.transform.localPosition = this.localPosition;
      }
    }
  }
}