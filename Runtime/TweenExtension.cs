using UnityEngine;
using Tweens.Core;

namespace Tweens {
  public static class TweenExtension {
    public static TweenInstance<ComponentType, DataType> AddTween<ComponentType, DataType>(this GameObject target, Tween<ComponentType, DataType> tween) {
      var instance = new TweenInstance<ComponentType, DataType>(target, tween);
      TweenEngine.Add(instance);
      return instance;
    }
  }
}