using System.Collections.Generic;

namespace Tweens.Core {
  class TweenEngine {
    static readonly List<Tween> tweens = new ();
    static readonly List<Tween> registerQueue = new ();
    static readonly List<Tween> unregisterQueue = new ();

    internal static void Register (Tween tween) {
      registerQueue.Add (tween);
    }

    internal static void Unregister (Tween tween) {
      unregisterQueue.Add (tween);
    }

    internal static void Update () {
      foreach (var tween in registerQueue) {
        tweens.Add (tween);
        tween.Awake ();
      }
      registerQueue.Clear ();
      foreach (var tween in tweens) {
        if (tween.gameObject == null) {
          tween.Cancel ();
          continue;
        }
        tween.Update ();
      }
      foreach (var tween in unregisterQueue) {
        tweens.Remove (tween);
      }
      unregisterQueue.Clear ();
    }

    internal static void Destroy () {
      foreach (var tween in tweens) {
        tween.Cancel ();
      }
      tweens.Clear ();
    }
  }
}