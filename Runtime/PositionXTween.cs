using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class PositionXTween {
    public static Tween<float> TweenPositionX (this Component self, float to, float duration) =>
      self.gameObject.TweenPositionX (to, duration);

    public static Tween<float> TweenPositionX (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Vector3 position;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.position.x;
      }

      public override void OnUpdate (float easedTime) {
        this.position = this.transform.position;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.position.x = this.valueCurrent;
        this.transform.position = this.position;
      }
    }
  }
}