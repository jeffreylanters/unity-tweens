using UnityEngine;
using UnityEngine.UI;

namespace UnityPackages.Tweens {
  public class GraphicAlphaTween : Tween<float> {
    private bool hasGraphic;
    private Graphic graphic;
    private Color color;

    public override float OnGetFrom () {
      this.graphic = this.gameObject.GetComponent<Graphic> ();
      this.hasGraphic = this.graphic != null;
      return this.hasGraphic == true ? this.graphic.color.a : 0;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      if (this.hasGraphic == true) {
        this.color = this.graphic.color;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.color.a = this.valueCurrent;
        this.graphic.color = this.color;
      }
    }
  }
}