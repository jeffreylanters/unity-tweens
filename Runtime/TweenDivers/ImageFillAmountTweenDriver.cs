using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens.TweenDrivers {
  [AddComponentMenu ("")]
  public class ImageFillAmountTweenDriver : TweenBase<float> {
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