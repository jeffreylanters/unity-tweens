using System;
using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class ValueVector2Tween {
    public static Tween<Vector2> TweenValueVector2 (this Component self, Vector2 to, float duration, Action<Vector2> onUpdate) =>
      Tween<Vector2>.Add<Driver> (self).SetOnUpdate (onUpdate).Finalize (to, duration);

    public static Tween<Vector2> TweenValueVector2 (this GameObject self, Vector2 to, float duration, Action<Vector2> onUpdate) =>
      Tween<Vector2>.Add<Driver> (self).SetOnUpdate (onUpdate).Finalize (to, duration);

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<Vector2> {
      private Action<Vector2> onUpdate = null;
      private bool hasOnUpdate = false;

      public override bool OnInitialize () {
        return true;
      }

      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override Vector2 OnGetFrom () {
        return Vector2.zero;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.valueCurrent.x = this.InterpolateValue (this.valueFrom.x, this.valueTo.x, easedTime);
        this.valueCurrent.y = this.InterpolateValue (this.valueFrom.y, this.valueTo.y, easedTime);
        if (this.hasOnUpdate == true)
          this.onUpdate (this.valueCurrent);
      }

      public Tween<Vector2> SetOnUpdate (Action<Vector2> onUpdate) {
        this.onUpdate = onUpdate;
        this.hasOnUpdate = true;
        return this;
      }
    }
  }
}