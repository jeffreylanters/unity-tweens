using UnityEngine;

namespace Tweens.Core {
  [AddComponentMenu("")]
  class TweenBehaviour : MonoBehaviour {
    static TweenBehaviour instance;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    internal static void Initialize() {
#if UNITY_EDITOR
      if (instance != null) {
        return;
      }
#endif
      instance = new GameObject("TweenBehaviour").AddComponent<TweenBehaviour>();
      DontDestroyOnLoad(instance.gameObject);
    }

    internal void LateUpdate() {
      TweenEngine.Update();
    }
  }
}