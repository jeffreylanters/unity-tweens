using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class PositionYTween {
    public static Tween<float> TweenPositionY (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenPositionY (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float, Transform> {
      private Vector3 position;

      public override float OnGetFrom () {
        return this.component.position.y;
      }

      public override void OnUpdate (float easedTime) {
        this.position = this.component.position;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.position.y = this.valueCurrent;
        this.component.position = this.position;
      }
    }
  }
}