using UnityEngine;

namespace ElRaccoone.Tweens.Core {
  public abstract class TweenInstance : MonoBehaviour {
    public void Cancel () {
      Object.Destroy (this);
    }
  }
}