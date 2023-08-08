using System.Collections.Generic;
using UnityEngine;

namespace Tweens.Core {
  static class TweenEngine {
    static readonly List<TweenInstance> active = new();
    static readonly List<TweenInstance> removeQueue = new();

    internal static void Add(TweenInstance tweenInstance) {
      active.Add(tweenInstance);
    }

    internal static void Remove(TweenInstance tweenInstance) {
      removeQueue.Add(tweenInstance);
    }

    internal static void Update() {
      foreach (var tweenInstance in active) {
        if (tweenInstance.target == null) {
          tweenInstance.Cancel();
          continue;
        }
        tweenInstance.Update();
      }
      foreach (var tweenInstance in removeQueue) {
        active.Remove(tweenInstance);
      }
      removeQueue.Clear();
    }

    internal static void Destroy() {
      foreach (var tweenInstance in active) {
        tweenInstance.Cancel();
      }
      active.Clear();
    }
  }
}