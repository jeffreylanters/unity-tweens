using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class GraphicAlphaTweenDriver : TweenBase<float> {
    private bool hasGraphic;
    private Graphic graphic;
    private Color color;

    public override void OnInitialize () {
      this.graphic = this.gameObject.GetComponent<Graphic> ();
      this.hasGraphic = this.graphic != null;
    }

    public override float OnGetFrom () {
      return this.hasGraphic == true ? this.graphic.color.a : 0;
    }

    public override void OnUpdate (float easedTime) {
      if (this.hasGraphic == true) {
        this.color = this.graphic.color;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.color.a = this.valueCurrent;
        this.graphic.color = this.color;
      }
    }
  }
}