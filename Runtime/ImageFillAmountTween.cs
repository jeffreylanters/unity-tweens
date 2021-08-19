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

    private class Driver : Tween<float, Image> {
      public override float OnGetFrom () {
        return this.component.fillAmount;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.fillAmount = this.valueCurrent;
      }
    }
  }
}

#endif