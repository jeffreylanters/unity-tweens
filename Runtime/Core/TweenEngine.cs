using System.Collections.Generic;

namespace Tweens.Core {
  static class TweenEngine {
    internal static readonly List<TweenInstance> instances = new();

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