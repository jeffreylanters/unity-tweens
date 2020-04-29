using UnityEngine;

namespace ElRaccoone.Tweens.Core {

  /// Instance class for all Tweens.
  public abstract class TweenInstance : MonoBehaviour {
    internal bool isDecommissioned = false;
    
    private Action onCancel = null;
    private bool hasOnCancel = false;

    /// Destroys the component.
    internal void Decommission () {
      this.isDecommissioned = true;
      Object.Destroy (this);
    }

    /// Cancel the tween and decommision the component.
    public void Cancel () {
      if (this.hasOnCancel == true)
        this.onCancel();
      this.Decommission ();
    }
  }
}
