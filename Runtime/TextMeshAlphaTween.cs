using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class TextMeshAlphaTween {
    public static Tween<float> TweenTextMeshAlpha (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenTextMeshAlpha (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float> {
      private TextMesh textMesh;
      private Color color;

      public override bool OnInitialize () {
        this.textMesh = this.gameObject.GetComponent<TextMesh> ();
        return this.textMesh != null;
      }

      public override float OnGetFrom () {
        return this.textMesh.color.a;
      }

      public override void OnUpdate (float easedTime) {
        this.color = this.textMesh.color;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.color.a = this.valueCurrent;
        this.textMesh.color = this.color;
      }
    }
  }
}