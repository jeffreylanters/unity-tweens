using System;
using UnityEngine;

namespace ElRaccoone.Tweens.Core {

  /// Instance class for all Tweens.
  public abstract class TweenBase : MonoBehaviour {
    internal bool isDecommissioned = false;

    internal Action onCancel = null;
    internal bool hasOnCancel = false;

    /// Destroys the component.
    internal void Decommission () {
      this.isDecommissioned = true;
      UnityEngine.Object.Destroy (this);
    }

    /// Cancel the tween and decommision the component.
    public void Cancel () {
      if (this.hasOnCancel == true)
        this.onCancel ();
      this.Decommission ();
    }
  }
}