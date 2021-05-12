#if TWEENS_TEXTMESHPRO

using ElRaccoone.Tweens.Core;
using UnityEngine;
using TMPro;

namespace ElRaccoone.Tweens {
  public static class TextMeshProAlphaTween {
    public static Tween<float> TweenTextMeshProAlpha (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenTextMeshProAlpha (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float> {
      private TextMeshPro textMeshPro;
      private Color color;

      public override bool OnInitialize () {
        this.textMeshPro = this.gameObject.GetComponent<TextMeshPro> ();
        return this.textMeshPro != null;
      }

      public override float OnGetFrom () {
        return this.textMeshPro.color.a;
      }

      public override void OnUpdate (float easedTime) {
        this.color = this.textMeshPro.color;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.color.a = this.valueCurrent;
        this.textMeshPro.color = this.color;
      }
    }
  }
}

#endif