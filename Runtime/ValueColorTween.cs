using System;
using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class ValueColorTween {
    public static Tween<Color> TweenValueColor (this Component self, Color to, float duration, Action<Color> onUpdate) =>
      Tween<Color>.Add<Driver> (self).SetOnUpdate (onUpdate).Finalize (duration, to);

    public static Tween<Color> TweenValueColor (this GameObject self, Color to, float duration, Action<Color> onUpdate) =>
      Tween<Color>.Add<Driver> (self).SetOnUpdate (onUpdate).Finalize (duration, to);

    private class Driver : Tween<Color> {
      private Action<Color> onUpdate = null;
      private bool hasOnUpdate = false;

      public override bool OnInitialize () {
        return true;
      }

      public override Color OnGetFrom () {
        return Color.black;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent.r = this.InterpolateValue (this.valueFrom.r, this.valueTo.r, easedTime);
        this.valueCurrent.g = this.InterpolateValue (this.valueFrom.g, this.valueTo.g, easedTime);
        this.valueCurrent.b = this.InterpolateValue (this.valueFrom.b, this.valueTo.b, easedTime);
        this.valueCurrent.a = this.InterpolateValue (this.valueFrom.a, this.valueTo.a, easedTime);
        if (this.hasOnUpdate == true)
          this.onUpdate (this.valueCurrent);
      }

      public Tween<Color> SetOnUpdate (Action<Color> onUpdate) {
        this.onUpdate = onUpdate;
        this.hasOnUpdate = true;
        return this;
      }
    }
  }
}