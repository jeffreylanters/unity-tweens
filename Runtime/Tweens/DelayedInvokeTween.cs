using System;
using UnityEngine;

namespace UnityPackages.Tweens {
  public class DelayedInvokeTween : Tween<bool> {
    private Action onComplete = null;
    private bool hasOnComplete = false;

    public override bool OnGetFrom () {
      return false;
    }

    public override void OnUpdate (float easedTime, bool isCompleted) {
      if (isCompleted == true && this.hasOnComplete == true)
        this.onComplete ();
    }

    public Tween<bool> SetOnComplete (Action onComplete) {
      this.onComplete = onComplete;
      this.hasOnComplete = true;
      return this;
    }
  }
}