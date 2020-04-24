using UnityEngine;

namespace ElRaccoone.Tweens.Core {

  /// Instance class for all Tweens.
  public abstract class TweenInstance : MonoBehaviour {
    internal bool isDecommissioned = false;

    /// Cancel the tween and decommision the component.
    public void Cancel () {
      this.Decommission ();
    }

    /// Destroys the component.
    internal void Decommission () {
      this.isDecommissioned = true;
      Object.Destroy (this);
    }
  }
}