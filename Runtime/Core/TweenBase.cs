using UnityEngine;

namespace ElRaccoone.Tweens.Core {
  public abstract class TweenBase : MonoBehaviour {
    public void Cancel () {
      Object.Destroy (this);
    }
  }
}