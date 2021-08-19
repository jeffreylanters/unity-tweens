using System;
using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class ValueVector3Tween {
    public static Tween<Vector3> TweenValueVector3 (this Component self, Vector3 to, float duration, Action<Vector3> onUpdate) =>
      Tween<Vector3>.Add<Driver> (self).SetOnUpdate (onUpdate).Finalize (to, duration);

    public static Tween<Vector3> TweenValueVector3 (this GameObject self, Vector3 to, float duration, Action<Vector3> onUpdate) =>
      Tween<Vector3>.Add<Driver> (self).SetOnUpdate (onUpdate).Finalize (to, duration);

    /// <summary>
    /// The driver is responsible for updating the tween's state.
    /// </summary>
    private class Driver : Tween<Vector3> {
      private Action<Vector3> onUpdate = null;
      private bool hasOnUpdate = false;

      public override bool OnInitialize () {
        return true;
      }

      /// <summary>
      /// Overriden method which is called when the tween starts and should
      /// return the tween's initial value.
      /// </summary>
      public override Vector3 OnGetFrom () {
        return Vector3.zero;
      }

      /// <summary>
      /// Overriden method which is called every tween update and should be used
      /// to update the tween's value.
      /// </summary>
      /// <param name="easedTime">The current eased time of the tween's step.</param>
      public override void OnUpdate (float easedTime) {
        this.valueCurrent.x = this.InterpolateValue (this.valueFrom.x, this.valueTo.x, easedTime);
        this.valueCurrent.y = this.InterpolateValue (this.valueFrom.y, this.valueTo.y, easedTime);
        this.valueCurrent.z = this.InterpolateValue (this.valueFrom.z, this.valueTo.z, easedTime);
        if (this.hasOnUpdate == true)
          this.onUpdate (this.valueCurrent);
      }

      public Tween<Vector3> SetOnUpdate (Action<Vector3> onUpdate) {
        this.onUpdate = onUpdate;
        this.hasOnUpdate = true;
        return this;
      }
    }
  }
}