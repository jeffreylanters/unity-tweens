using UnityEngine;
using Tweens.Core;

namespace Tweens {
  public static class TweenExtension {
    public static TweenInstance<ComponentType, DataType> AddTween<ComponentType, DataType>(this GameObject target, Tween<ComponentType, DataType> tween) where ComponentType : Component {
      var instance = new TweenInstance<ComponentType, DataType>(target, tween);
      TweenEngine.instances.Add(instance);
      return instance;
    }

    public static void CancelTweens(this GameObject target, bool includeChildren = false) {
      var instances = TweenEngine.instances.FindAll(instance => {
        if (instance.target == target) {
          return true;
        }
        if (includeChildren) {
          return instance.target.transform.IsChildOf(target.transform);
        }
        return false;
      });
      foreach (var instance in instances) {
        instance.Cancel();
      }
    }
  }
}