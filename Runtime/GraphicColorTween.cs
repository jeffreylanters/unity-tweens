#if TWEENS_DEFINED_COM_UNITY_UGUI

using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens {
  public static class GraphicColorTween {
    public static Tween<Color> TweenGraphicColor (this Component self, Color to, float duration) =>
      Tween<Color>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<Color> TweenGraphicColor (this GameObject self, Color to, float duration) =>
      Tween<Color>.Add<Driver> (self).Finalize (to, duration);

    private class Driver : Tween<Color, Graphic> {
      public override Color OnGetFrom () {
        return this.component.color;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent.r = this.InterpolateValue (this.valueFrom.r, this.valueTo.r, easedTime);
        this.valueCurrent.g = this.InterpolateValue (this.valueFrom.g, this.valueTo.g, easedTime);
        this.valueCurrent.b = this.InterpolateValue (this.valueFrom.b, this.valueTo.b, easedTime);
        this.valueCurrent.a = this.InterpolateValue (this.valueFrom.a, this.valueTo.a, easedTime);
        this.component.color = this.valueCurrent;
      }
    }
  }
}

#endif