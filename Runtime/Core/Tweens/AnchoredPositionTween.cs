using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.Core.Drivers {
  [AddComponentMenu ("")]
  public class AnchoredPositionTween : Tween<Vector2> {
    private RectTransform rectTransform;

    public override bool OnInitialize () {
      this.rectTransform = this.gameObject.GetComponent<RectTransform> ();
      return this.rectTransform != null;
    }

    public override Vector2 OnGetFrom () {
      return this.rectTransform.anchoredPosition;
    }

    public override void OnUpdate (float easedTime) {
      this.valueCurrent.x = this.InterpolateValue (this.valueFrom.x, this.valueTo.x, easedTime);
      this.valueCurrent.y = this.InterpolateValue (this.valueFrom.y, this.valueTo.y, easedTime);
      this.rectTransform.anchoredPosition = this.valueCurrent;
    }
  }
}