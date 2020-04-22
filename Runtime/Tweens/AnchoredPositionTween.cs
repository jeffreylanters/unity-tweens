using UnityEngine;

namespace UnityPackages.Tweens {
  public class AnchoredPositionTween : Tween<Vector2> {
    private bool hasRectTransform;
    private RectTransform rectTransform;

    public override Vector2 OnGetFrom () {
      this.rectTransform = this.gameObject.GetComponent<RectTransform> ();
      this.hasRectTransform = this.rectTransform != null;
      return this.hasRectTransform == true ? this.rectTransform.anchoredPosition : Vector2.zero;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      if (this.hasRectTransform == true) {
        this.valueCurrent.x = Mathf.Lerp (this.valueFrom.x, this.valueTo.x, easedTime);
        this.valueCurrent.y = Mathf.Lerp (this.valueFrom.y, this.valueTo.y, easedTime);
        this.rectTransform.anchoredPosition = this.valueCurrent;
      }
    }
  }
}