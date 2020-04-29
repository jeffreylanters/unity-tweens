using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens {
  public static class MaterialAlphaTween {
    public static Tween<float> TweenMaterialAlpha (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenMaterialAlpha (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float> {
      private MeshRenderer meshRenderer;
      private Material material;
      private Color color;

      public override bool OnInitialize () {
        this.meshRenderer = this.gameObject.GetComponent<MeshRenderer> ();
        if (this.meshRenderer != null)
          this.material = this.meshRenderer.material;
        return this.meshRenderer != null;
      }

      public override float OnGetFrom () {
        return this.material.color.a;
      }

      public override void OnUpdate (float easedTime) {
        this.color = this.material.color;
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.color.a = this.valueCurrent;
        this.material.color = this.color;
      }
    }
  }
}