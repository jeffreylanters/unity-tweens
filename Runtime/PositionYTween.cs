using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class PositionYTween {
    public static Tween<float> TweenPositionY (this Component self, float to, float duration) =>
      self.gameObject.TweenPositionY (to, duration);

    public static Tween<float> TweenPositionY (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private Vector3 position;

      public override bool OnInitialize () {
        return true;
      }

      public override float OnGetFrom () {
        return this.transform.position.y;
      }

      public override void OnUpdate (float easedTime) {
        this.position = this.transform.position;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.position.y = this.valueCurrent;
        this.transform.position = this.position;
      }
    }
  }
}