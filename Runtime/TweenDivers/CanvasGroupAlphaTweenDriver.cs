using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  [AddComponentMenu ("")]
  public class CanvasGroupAlphaTweenDriver : TweenBase<float> {
    private CanvasGroup canvasGroup;

    public override bool OnInitialize () {
      this.canvasGroup = this.gameObject.GetComponent<CanvasGroup> ();
      return this.canvasGroup != null;
    }

    public override float OnGetFrom () {
      return this.canvasGroup.alpha;
    }

    public override void OnUpdate (float easedTime) {
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.canvasGroup.alpha = this.valueCurrent;
    }
  }
}