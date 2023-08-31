using System.Collections.Generic;
using UnityEngine;

namespace Tweens.Core {
  static class TweenEngine {
    readonly internal static List<TweenInstance> instances = new();

    #if UNITY_EDITOR
    [RuntimeInitializeOnLoadMethod (RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void ClearInstances () {
      instances.Clear ();
    }
    #endif

    internal static void Update() {
      for (var i = 0; i < instances.Count; i++) {
        var instance = instances[i];
        if (instance.isDecommissioned) {
          instances.Remove(instance);
          i--;
          continue;
        }
        instance.Update();
      }
    }
  }
}