using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens {
  public static class ImageFillAmountTween {
    public static Tween<float> TweenImageFillAmount (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenImageFillAmount (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float> {
      private Image image;

      public override bool OnInitialize () {
        this.image = this.gameObject.GetComponent<Image> ();
        return this.image != null;
      }

      public override float OnGetFrom () {
        return this.image.fillAmount;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.image.fillAmount = this.valueCurrent;
      }
    }
  }
}