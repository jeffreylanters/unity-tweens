#if TWEENS_DEFINED_COM_UNITY_TEXTMESHPRO

using ElRaccoone.Tweens.Core;
using UnityEngine;
using TMPro;

namespace ElRaccoone.Tweens {
  public static class TextMeshProAlphaTween {
    public static Tween<float> TweenTextMeshProAlpha (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenTextMeshProAlpha (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<float, TextMeshPro> {
      private Color color;

      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override float OnGetFrom () {
        return this.component.color.a;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.color = this.component.color;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.color.a = this.valueCurrent;
        this.component.color = this.color;
      }
    }
  }
}

#endif