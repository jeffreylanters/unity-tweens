using UnityEngine;

namespace ElRaccoone.Tweens.Core {
  public static class Easer {
    private const float constantA = 1.70158f;
    private const float constantB = constantA * 1.525f;
    private const float constantC = constantA + 1f;
    private const float constantD = (2f * Mathf.PI) / 3f;
    private const float constantE = (2f * Mathf.PI) / 4.5f;
    private const float constantF = 7.5625f;
    private const float constantG = 2.75f;

    public static float Apply (Ease ease, float time) {
      switch (ease) {
        default : return 0;
        case Ease.Linear:
            return Easer.Linear (time);
        case Ease.SineIn:
            return Easer.SineIn (time);
        case Ease.SineOut:
            return Easer.SineOut (time);
        case Ease.SineInOut:
            return Easer.SineInOut (time);
        case Ease.QuadIn:
            return Easer.QuadIn (time);
        case Ease.QuadOut:
            return Easer.QuadOut (time);
        case Ease.QuadInOut:
            return Easer.QuadInOut (time);
        case Ease.CubicIn:
            return Easer.CubicIn (time);
        case Ease.CubicOut:
            return Easer.CubicOut (time);
        case Ease.CubicInOut:
            return Easer.CubicInOut (time);
        case Ease.QuartIn:
            return Easer.QuartIn (time);
        case Ease.QuartOut:
            return Easer.QuartOut (time);
        case Ease.QuartInOut:
            return Easer.QuartInOut (time);
        case Ease.QuintIn:
            return Easer.QuintIn (time);
        case Ease.QuintOut:
            return Easer.QuintOut (time);
        case Ease.QuintInOut:
            return Easer.QuintInOut (time);
        case Ease.ExpoIn:
            return Easer.ExpoIn (time);
        case Ease.ExpoOut:
            return Easer.ExpoOut (time);
        case Ease.ExpoInOut:
            return Easer.ExpoInOut (time);
        case Ease.CircIn:
            return Easer.CircIn (time);
        case Ease.CircOut:
            return Easer.CircOut (time);
        case Ease.CircInOut:
            return Easer.CircInOut (time);
        case Ease.BackIn:
            return Easer.BackIn (time);
        case Ease.BackOut:
            return Easer.BackOut (time);
        case Ease.BackInOut:
            return Easer.BackInOut (time);
        case Ease.ElasticIn:
            return Easer.ElasticIn (time);
        case Ease.ElasticOut:
            return Easer.ElasticOut (time);
        case Ease.ElasticInOut:
            return Easer.ElasticInOut (time);
        case Ease.BounceIn:
            return Easer.BounceIn (time);
        case Ease.BounceOut:
            return Easer.BounceOut (time);
        case Ease.BounceInOut:
            return Easer.BounceInOut (time);
      }
    }

    private static float Linear (float time) {
      return time;
    }

    private static float SineIn (float time) {
      return 1f - Mathf.Cos ((time * Mathf.PI) / 2f);
    }

    private static float SineOut (float time) {
      return Mathf.Sin ((time * Mathf.PI) / 2f);
    }

    private static float SineInOut (float time) {
      return -(Mathf.Cos (Mathf.PI * time) - 1f) / 2f;
    }

    private static float QuadIn (float time) {
      return time * time;
    }

    private static float QuadOut (float time) {
      return 1 - (1 - time) * (1 - time);
    }

    private static float QuadInOut (float time) {
      return time < 0.5f ? 2 * time * time : 1 - Mathf.Pow (-2 * time + 2, 2) / 2;
    }

    private static float CubicIn (float time) {
      return time * time * time;
    }

    private static float CubicOut (float time) {
      return 1 - Mathf.Pow (1 - time, 3);
    }

    private static float CubicInOut (float time) {
      return time < 0.5f ? 4 * time * time * time : 1 - Mathf.Pow (-2 * time + 2, 3) / 2;
    }

    private static float QuartIn (float time) {
      return time * time * time * time;
    }

    private static float QuartOut (float time) {
      return 1 - Mathf.Pow (1 - time, 4);
    }

    private static float QuartInOut (float time) {
      return time < 0.5 ? 8 * time * time * time * time : 1 - Mathf.Pow (-2 * time + 2, 4) / 2;
    }

    private static float QuintIn (float time) {
      return time * time * time * time * time;
    }

    private static float QuintOut (float time) {
      return 1 - Mathf.Pow (1 - time, 5);
    }

    private static float QuintInOut (float time) {
      return time < 0.5f ? 16 * time * time * time * time * time : 1 - Mathf.Pow (-2 * time + 2, 5) / 2;
    }

    private static float ExpoIn (float time) {
      return time == 0 ? 0 : Mathf.Pow (2, 10 * time - 10);
    }

    private static float ExpoOut (float time) {
      return time == 1 ? 1 : 1 - Mathf.Pow (2, -10 * time);
    }

    private static float ExpoInOut (float time) {
      return time == 0 ? 0 : time == 1 ? 1 : time < 0.5 ? Mathf.Pow (2, 20 * time - 10) / 2 : (2 - Mathf.Pow (2, -20 * time + 10)) / 2;
    }

    private static float CircIn (float time) {
      return 1 - Mathf.Sqrt (1 - Mathf.Pow (time, 2));
    }

    private static float CircOut (float time) {
      return Mathf.Sqrt (1 - Mathf.Pow (time - 1, 2));
    }

    private static float CircInOut (float time) {
      return time < 0.5 ? (1 - Mathf.Sqrt (1 - Mathf.Pow (2 * time, 2))) / 2 : (Mathf.Sqrt (1 - Mathf.Pow (-2 * time + 2, 2)) + 1) / 2;
    }

    private static float BackIn (float time) {
      return constantC * time * time * time - constantA * time * time;
    }

    private static float BackOut (float time) {
      return 1f + constantC * Mathf.Pow (time - 1, 3) + constantA * Mathf.Pow (time - 1, 2);
    }

    private static float BackInOut (float time) {
      return time < 0.5 ?
        (Mathf.Pow (2 * time, 2) * ((constantB + 1) * 2 * time - constantB)) / 2 :
        (Mathf.Pow (2 * time - 2, 2) * ((constantB + 1) * (time * 2 - 2) + constantB) + 2) / 2;
    }

    private static float ElasticIn (float time) {
      return time == 0 ? 0 : time == 1 ? 1 : -Mathf.Pow (2, 10 * time - 10) * Mathf.Sin ((time * 10f - 10.75f) * constantD);
    }

    private static float ElasticOut (float time) {
      return time == 0 ? 0 : time == 1 ? 1 : Mathf.Pow (2, -10 * time) * Mathf.Sin ((time * 10 - 0.75f) * constantD) + 1;
    }

    private static float ElasticInOut (float time) {
      return time == 0 ? 0 : time == 1 ? 1 : time < 0.5 ? -(Mathf.Pow (2, 20 * time - 10) * Mathf.Sin ((20 * time - 11.125f) * constantE)) / 2 : (Mathf.Pow (2, -20 * time + 10) * Mathf.Sin ((20 * time - 11.125f) * constantE)) / 2 + 1;
    }

    private static float BounceIn (float time) {
      return 1 - Easer.BounceOut (1 - time);
    }

    private static float BounceOut (float time) {
      if (time < 1 / constantG)
        return constantF * time * time;
      else if (time < 2 / constantG)
        return constantF * (time -= 1.5f / constantG) * time + 0.75f;
      else if (time < 2.5f / constantG)
        return constantF * (time -= 2.25f / constantG) * time + 0.9375f;
      else
        return constantF * (time -= 2.625f / constantG) * time + 0.984375f;
    }

    private static float BounceInOut (float time) {
      return time < 0.5f ? (1 - Easer.BounceOut (1 - 2 * time)) / 2 : (1 + Easer.BounceOut (2 * time - 1)) / 2;
    }
  }
}