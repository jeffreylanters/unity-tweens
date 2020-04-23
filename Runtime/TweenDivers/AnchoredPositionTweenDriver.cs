using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class AnchoredPositionTweenDriver : TweenMotor<Vector2> {
    private bool hasRectTransform;
    private RectTransform rectTransform;

    public override Vector2 OnGetFrom () {
      this.rectTransform = this.gameObject.GetComponent<RectTransform> ();
      this.hasRectTransform = this.rectTransform != null;
      return this.hasRectTransform == true ? this.rectTransform.anchoredPosition : Vector2.zero;
    }

    public override void OnUpdate (float easedTime) {
      if (this.hasRectTransform == true) {
        this.valueCurrent.x = this.InterpolateValue (this.valueFrom.x, this.valueTo.x, easedTime);
        this.valueCurrent.y = this.InterpolateValue (this.valueFrom.y, this.valueTo.y, easedTime);
        this.rectTransform.anchoredPosition = this.valueCurrent;
      }
    }
  }
}