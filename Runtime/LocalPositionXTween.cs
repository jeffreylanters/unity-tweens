using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalPositionXTween {
    public static Tween<float> TweenLocalPositionX (this Component self, float to, float duration) =>
      self.gameObject.TweenLocalPositionX (to, duration);

    public static Tween<float> TweenLocalPositionX (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Vector3 localPosition;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.localPosition.x;
      }

      public override void OnUpdate (float easedTime) {
        this.localPosition = this.transform.localPosition;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.localPosition.x = this.valueCurrent;
        this.transform.localPosition = this.localPosition;
      }
    }
  }
}