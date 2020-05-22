using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class SpriteRendererColorTween {
    public static Tween<Color> TweenSpriteRendererColor (this Component self, Color to, float duration) =>
      Tween<Color>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<Color> TweenSpriteRendererColor (this GameObject self, Color to, float duration) =>
      Tween<Color>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<Color> {
      private SpriteRenderer spriteRenderer;

      public override bool OnInitialize () {
        this.spriteRenderer = this.gameObject.GetComponent<SpriteRenderer> ();
        return this.spriteRenderer != null;
      }

      public override Color OnGetFrom () {
        return this.spriteRenderer.color;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent.r = this.InterpolateValue (this.valueFrom.r, this.valueTo.r, easedTime);
        this.valueCurrent.g = this.InterpolateValue (this.valueFrom.g, this.valueTo.g, easedTime);
        this.valueCurrent.b = this.InterpolateValue (this.valueFrom.b, this.valueTo.b, easedTime);
        this.valueCurrent.a = this.InterpolateValue (this.valueFrom.a, this.valueTo.a, easedTime);
        this.spriteRenderer.color = this.valueCurrent;
      }
    }
  }
}