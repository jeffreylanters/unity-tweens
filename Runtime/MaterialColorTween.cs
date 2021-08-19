using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class MaterialColorTween {
    public static Tween<Color> TweenMaterialColor (this Component self, Color to, float duration) =>
      Tween<Color>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<Color> TweenMaterialColor (this GameObject self, Color to, float duration) =>
      Tween<Color>.Add<Driver> (self).Finalize (to, duration);

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<Color> {
      private MeshRenderer meshRenderer;
      private Material material;
      private Color color;

      public override bool OnInitialize () {
        this.meshRenderer = this.gameObject.GetComponent<MeshRenderer> ();
        if (this.meshRenderer != null)
          this.material = this.meshRenderer.material;
        return this.meshRenderer != null;
      }

      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override Color OnGetFrom () {
        return this.material.color;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.color = this.material.color;
        this.valueCurrent.r = this.InterpolateValue (this.valueFrom.r, this.valueTo.r, easedTime);
        this.valueCurrent.g = this.InterpolateValue (this.valueFrom.g, this.valueTo.g, easedTime);
        this.valueCurrent.b = this.InterpolateValue (this.valueFrom.b, this.valueTo.b, easedTime);
        this.valueCurrent.a = this.InterpolateValue (this.valueFrom.a, this.valueTo.a, easedTime);
        this.color = this.valueCurrent;
        this.material.color = this.color;
      }
    }
  }
}