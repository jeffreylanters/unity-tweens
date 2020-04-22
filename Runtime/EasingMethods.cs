using UnityEngine;

namespace UnityPackages.Tweens {
  public static class EasingMethods {
    public static float ByEase (Ease ease, float time) {
      switch (ease) {
        default : return 0;
        case Ease.Linear:
            return EasingMethods.Linear (time);
        case Ease.SineIn:
            return EasingMethods.SineIn (time);
        case Ease.SineOut:
            return EasingMethods.SineOut (time);
        case Ease.SineInOut:
            return EasingMethods.SineInOut (time);
        case Ease.BackIn:
            return EasingMethods.BackIn (time);
      }
    }

    public static float Linear (float time) {
      return time;
    }

    public static float SineIn (float time) {
      return 1f - Mathf.Cos ((time * Mathf.PI) / 2f);
    }

    public static float SineOut (float time) {
      return Mathf.Sin ((time * Mathf.PI) / 2f);
    }

    public static float SineInOut (float time) {
      return -(Mathf.Cos (Mathf.PI * time) - 1f) / 2f;
    }

    private const float backConstantA = 1.70158f;
    private const float backConstantB = 2.70158f;

    public static float BackIn (float time) {
      var x = backConstantB * time * time * time - backConstantA * time * time;
      Debug.Log (x);
      return x;
    }
  }
}