#if TWEENS_DEFINED_COM_UNITY_UGUI

using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens {
  public static class ImageFillAmountTween {
    public static Tween<float> TweenImageFillAmount (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenImageFillAmount (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<float, Image> {
      
      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override float OnGetFrom () {
        return this.component.fillAmount;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.fillAmount = this.valueCurrent;
      }
    }
  }
}

#endif