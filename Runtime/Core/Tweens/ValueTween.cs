using System;
using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.Core.Drivers {
  [AddComponentMenu ("")]
  public class ValueTween : Tween<float> {
    private Action<float> onUpdate = null;
    private bool hasOnUpdate = false;

    public override bool OnInitialize () {
      return true;
    }

    public override float OnGetFrom () {
      return 0;
    }

    public override void OnUpdate (float easedTime) {
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      if (this.hasOnUpdate == true)
        this.onUpdate (this.valueCurrent);
    }

    public Tween<float> SetOnUpdate (Action<float> onUpdate) {
      this.onUpdate = onUpdate;
      this.hasOnUpdate = true;
      return this;
    }
  }
}