using UnityEngine;

namespace UnityPackages.Tweens {
  public class AnchoredPositionYTween : Tween<float> {
    private bool hasRectTransform;
    private RectTransform rectTransform;
    private Vector2 anchoredPosition;

    public override float OnGetFrom () {
      this.rectTransform = this.gameObject.GetComponent<RectTransform> ();
      this.hasRectTransform = this.rectTransform != null;
      return this.hasRectTransform == true ? this.rectTransform.anchoredPosition.y : 0;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      if (this.hasRectTransform == true) {
        this.anchoredPosition = this.rectTransform.anchoredPosition;
        this.valueCurrent = Mathf.Lerp (this.valueFrom, this.valueTo, easedTime);
        this.anchoredPosition.y = this.valueCurrent;
        this.rectTransform.anchoredPosition = this.anchoredPosition;
      }
    }
  }
}