using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.Core.Drivers {
  [AddComponentMenu ("")]
  public class DelayedInvokeTween : Tween<bool> {
    public override bool OnInitialize () {
      return true;
    }

    public override bool OnGetFrom () {
      return true;
    }

    public override void OnUpdate (float easedTime) { }
  }
}