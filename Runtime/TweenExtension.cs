using UnityEngine;
using Tweens.Core;

namespace Tweens {
  public static class TweenExtension {
    public static TweenInstance<ComponentType, DataType> AddTween<ComponentType, DataType>(this GameObject target, Tween<ComponentType, DataType> tween) where ComponentType : Component {
      var instance = new TweenInstance<ComponentType, DataType>(target, tween);
      TweenEngine.Add(instance);
      return instance;
    }

    public static TweenInstance<ComponentType, DataType> AddTween<ComponentType, DataType>(this Component target, Tween<ComponentType, DataType> tween) where ComponentType : Component {
      return target.gameObject.AddTween(tween);
    }

    public static void CancelTweens(this GameObject target) {
      var instances = TweenEngine.Get(target);
      foreach (var instance in instances) {
        instance.Cancel();
      }
    }
  }
}