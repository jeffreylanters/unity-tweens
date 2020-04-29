using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class CancelAllTween {
    public static void TweenCancelAll (this Component self, bool includeChildren = false, bool includeInactive = false) =>
      self.gameObject.TweenCancelAll (includeChildren, includeInactive);

    public static void TweenCancelAll (this GameObject self, bool includeChildren = false, bool includeInactive = false) {
      var _tweensInstances = includeChildren == true ?
        self.GetComponentsInChildren<ITween> (includeInactive) :
        self.GetComponents<ITween> ();
      foreach (var _tweenInstance in _tweensInstances)
        _tweenInstance.Cancel ();
    }
  }
}