using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class LocalScaleZTween {
    public static Tween<float> TweenLocalScaleZ (this Component self, float to, float duration) =>
      self.gameObject.TweenLocalScaleZ (to, duration);

    public static Tween<float> TweenLocalScaleZ (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Vector3 localScale;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.localScale.z;
      }

      public override void OnUpdate (float easedTime) {
        this.localScale = this.transform.localScale;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.localScale.z = this.valueCurrent;
        this.transform.localScale = this.localScale;
      }
    }
  }
}