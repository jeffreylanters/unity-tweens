using UnityEngine;

namespace ElRaccoone.Tweens.Core {

  /// Instance class for all Tweens.
  public abstract class TweenInstance : MonoBehaviour {

    /// Cancel the tween and decommision the component.
    public void Cancel () {
      this.Decommission ();
    }

    /// Destroys the component.
    internal void Decommission () {
      Object.Destroy (this);
    }
  }
}