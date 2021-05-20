using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class SpriteRendererAlphaTween {
    public static Tween<float> TweenSpriteRendererAlpha (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenSpriteRendererAlpha (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float, SpriteRenderer> {
      private Color color;

      public override float OnGetFrom () {
        return this.component.color.a;
      }

      public override void OnUpdate (float easedTime) {
        this.color = this.component.color;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.color.a = this.valueCurrent;
        this.component.color = this.color;
      }
    }
  }
}