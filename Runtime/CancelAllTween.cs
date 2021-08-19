using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {

  /// <summary>
  /// Tween class to cancel all tweens.
  /// </summary>
  public static class CancelAllTween {

    /// <summary>
    /// Cancels all the tweens on the component's game object.
    /// </summary>
    /// <param name="self">The component.</param>
    /// <param name="includeChildren">Defines whether to include the tweens on the child game objects.</param>
    /// <param name="includeInactive">Defines whether to include the tweens on disabled game ovjects.</param>
    public static void TweenCancelAll (this Component self, bool includeChildren = false, bool includeInactive = false) =>
      self.gameObject.TweenCancelAll (includeChildren, includeInactive);

    /// <summary>
    /// Cancels all the tweens on the game object.
    /// </summary>
    /// <param name="self">The component.</param>
    /// <param name="includeChildren">Defines whether to include the tweens on the child game objects.</param>
    /// <param name="includeInactive">Defines whether to include the tweens on disabled game ovjects.</param>
    public static void TweenCancelAll (this GameObject self, bool includeChildren = false, bool includeInactive = false) {
      var _tweensInstances = includeChildren == true ?
        self.GetComponentsInChildren<ITween> (includeInactive) :
        self.GetComponents<ITween> ();
      foreach (var _tweenInstance in _tweensInstances)
        _tweenInstance.Cancel ();
    }
  }
}