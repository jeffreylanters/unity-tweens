using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class AnchoredPositionYTweenDriver : TweenBase<float> {
    private RectTransform rectTransform;
    private Vector2 anchoredPosition;

    public override bool OnInitialize () {
      this.rectTransform = this.gameObject.GetComponent<RectTransform> ();
      return this.rectTransform != null;
    }

    public override float OnGetFrom () {
      return this.rectTransform.anchoredPosition.y;
    }

    public override void OnUpdate (float easedTime) {
      this.anchoredPosition = this.rectTransform.anchoredPosition;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.anchoredPosition.y = this.valueCurrent;
      this.rectTransform.anchoredPosition = this.anchoredPosition;
    }
  }
}