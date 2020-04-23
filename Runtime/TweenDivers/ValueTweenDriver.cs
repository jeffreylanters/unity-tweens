using System;
using ElRaccoone.Tweens.Core;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class ValueTweenDriver : TweenMotor<float> {
    private Action<float> onUpdate = null;
    private bool hasOnUpdate = false;

    public override float OnGetFrom () {
      return 0;
    }

    public override void OnUpdate (float easedTime) {
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      if (this.hasOnUpdate == true)
        this.onUpdate (this.valueCurrent);
    }

    public TweenMotor<float> SetOnUpdate (Action<float> onUpdate) {
      this.onUpdate = onUpdate;
      this.hasOnUpdate = true;
      return this;
    }
  }
}