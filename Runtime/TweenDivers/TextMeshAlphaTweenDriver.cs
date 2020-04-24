using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  [AddComponentMenu ("")]
  public class TextMeshAlphaTweenDriver : TweenBase<float> {
    private TextMesh textMesh;
    private Color color;

    public override bool OnInitialize () {
      this.textMesh = this.gameObject.GetComponent<TextMesh> ();
      return this.textMesh != null;
    }

    public override float OnGetFrom () {
      return this.textMesh.color.a;
    }

    public override void OnUpdate (float easedTime) {
      this.color = this.textMesh.color;
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.color.a = this.valueCurrent;
      this.textMesh.color = this.color;
    }
  }
}