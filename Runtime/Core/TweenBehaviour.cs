using UnityEngine;

namespace Tweens.Core {
  [AddComponentMenu("")]
  class TweenBehaviour : MonoBehaviour {
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    internal static void Initialize() {
      DontDestroyOnLoad(new GameObject("TweenBehaviour", typeof(TweenBehaviour)));
    }

    internal void Update() {
      TweenEngine.Update();
    }

    internal void OnDestroy() {
      TweenEngine.Destroy();
    }

    internal void OnGUI() {
      TweenEngine.OnGUI();
    }
  }
}