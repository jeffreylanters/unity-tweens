using System;
using System.Collections;
using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  public class DelayedInvokeTweenDriver : TweenInstance {
    public TweenInstance Invoke (float duration, Action action) {
      this.StartCoroutine (this.InvokeCoroutine (duration, action));
      return this;
    }

    private IEnumerator InvokeCoroutine (float duration, Action action) {
      yield return new WaitForSeconds (duration);
      action ();
      UnityEngine.Object.Destroy (this);
    }
  }
}