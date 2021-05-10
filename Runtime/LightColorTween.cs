using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens {
  public static class LightColorTween {
    public static Tween<Color> TweenLightColor (this Component self, Color to, float duration) =>
      Tween<Color>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<Color> TweenLightColor (this GameObject self, Color to, float duration) =>
      Tween<Color>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<Color> {
      private new Light light;

      public override bool OnInitialize () {
        this.light = this.gameObject.GetComponent<Light> ();
        return this.light != null;
      }

      public override Color OnGetFrom () {
        return this.light.color;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent.r = this.InterpolateValue (this.valueFrom.r, this.valueTo.r, easedTime);
        this.valueCurrent.g = this.InterpolateValue (this.valueFrom.g, this.valueTo.g, easedTime);
        this.valueCurrent.b = this.InterpolateValue (this.valueFrom.b, this.valueTo.b, easedTime);
        this.valueCurrent.a = this.InterpolateValue (this.valueFrom.a, this.valueTo.a, easedTime);
        this.light.color = this.valueCurrent;
      }
    }
  }
}