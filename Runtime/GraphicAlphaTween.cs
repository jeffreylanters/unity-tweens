using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens {
  public static class GraphicAlphaTween {
    public static Tween<float> TweenGraphicAlpha (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenGraphicAlpha (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float> {
      private Graphic graphic;
      private Color color;

      public override bool OnInitialize () {
        this.graphic = this.gameObject.GetComponent<Graphic> ();
        return this.graphic != null;
      }

      public override float OnGetFrom () {
        return this.graphic.color.a;
      }

      public override void OnUpdate (float easedTime) {
        this.color = this.graphic.color;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.color.a = this.valueCurrent;
        this.graphic.color = this.color;
      }
    }
  }
}