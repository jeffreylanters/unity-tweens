using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class SpriteRendererAlphaTween {
    public static Tween<float> TweenSpriteRendererAlpha (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenSpriteRendererAlpha (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float> {
      private SpriteRenderer spriteRenderer;
      private Color color;

      public override bool OnInitialize () {
        this.spriteRenderer = this.gameObject.GetComponent<SpriteRenderer> ();
        return this.spriteRenderer != null;
      }

      public override float OnGetFrom () {
        return this.spriteRenderer.color.a;
      }

      public override void OnUpdate (float easedTime) {
        this.color = this.spriteRenderer.color;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.color.a = this.valueCurrent;
        this.spriteRenderer.color = this.color;
      }
    }
  }
}