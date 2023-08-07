using UnityEngine;

namespace Tweens.Core {
  internal static class Easer {
    const float constantA = 1.70158f;
    const float constantB = constantA * 1.525f;
    const float constantC = constantA + 1f;
    const float constantD = (2f * Mathf.PI) / 3f;
    const float constantE = (2f * Mathf.PI) / 4.5f;
    const float constantF = 7.5625f;
    const float constantG = 2.75f;

    internal static float Apply(EaseType ease, float time) {
      return ease switch {
        EaseType.Linear => Easer.Linear(time),
        EaseType.SineIn => Easer.SineIn(time),
        EaseType.SineOut => Easer.SineOut(time),
        EaseType.SineInOut => Easer.SineInOut(time),
        EaseType.QuadIn => Easer.QuadIn(time),
        EaseType.QuadOut => Easer.QuadOut(time),
        EaseType.QuadInOut => Easer.QuadInOut(time),
        EaseType.CubicIn => Easer.CubicIn(time),
        EaseType.CubicOut => Easer.CubicOut(time),
        EaseType.CubicInOut => Easer.CubicInOut(time),
        EaseType.QuartIn => Easer.QuartIn(time),
        EaseType.QuartOut => Easer.QuartOut(time),
        EaseType.QuartInOut => Easer.QuartInOut(time),
        EaseType.QuintIn => Easer.QuintIn(time),
        EaseType.QuintOut => Easer.QuintOut(time),
        EaseType.QuintInOut => Easer.QuintInOut(time),
        EaseType.ExpoIn => Easer.ExpoIn(time),
        EaseType.ExpoOut => Easer.ExpoOut(time),
        EaseType.ExpoInOut => Easer.ExpoInOut(time),
        EaseType.CircIn => Easer.CircIn(time),
        EaseType.CircOut => Easer.CircOut(time),
        EaseType.CircInOut => Easer.CircInOut(time),
        EaseType.BackIn => Easer.BackIn(time),
        EaseType.BackOut => Easer.BackOut(time),
        EaseType.BackInOut => Easer.BackInOut(time),
        EaseType.ElasticIn => Easer.ElasticIn(time),
        EaseType.ElasticOut => Easer.ElasticOut(time),
        EaseType.ElasticInOut => Easer.ElasticInOut(time),
        EaseType.BounceIn => Easer.BounceIn(time),
        EaseType.BounceOut => Easer.BounceOut(time),
        EaseType.BounceInOut => Easer.BounceInOut(time),
        _ => 0,
      };
    }

    static float Linear(float time) {
      return time;
    }

    static float SineIn(float time) {
      return 1f - Mathf.Cos((time * Mathf.PI) / 2f);
    }

    static float SineOut(float time) {
      return Mathf.Sin((time * Mathf.PI) / 2f);
    }

    static float SineInOut(float time) {
      return -(Mathf.Cos(Mathf.PI * time) - 1f) / 2f;
    }

    static float QuadIn(float time) {
      return time * time;
    }

    static float QuadOut(float time) {
      return 1 - (1 - time) * (1 - time);
    }

    static float QuadInOut(float time) {
      return time < 0.5f ? 2 * time * time : 1 - Mathf.Pow(-2 * time + 2, 2) / 2;
    }

    static float CubicIn(float time) {
      return time * time * time;
    }

    static float CubicOut(float time) {
      return 1 - Mathf.Pow(1 - time, 3);
    }

    static float CubicInOut(float time) {
      return time < 0.5f ? 4 * time * time * time : 1 - Mathf.Pow(-2 * time + 2, 3) / 2;
    }

    static float QuartIn(float time) {
      return time * time * time * time;
    }

    static float QuartOut(float time) {
      return 1 - Mathf.Pow(1 - time, 4);
    }

    static float QuartInOut(float time) {
      return time < 0.5 ? 8 * time * time * time * time : 1 - Mathf.Pow(-2 * time + 2, 4) / 2;
    }

    static float QuintIn(float time) {
      return time * time * time * time * time;
    }

    static float QuintOut(float time) {
      return 1 - Mathf.Pow(1 - time, 5);
    }

    static float QuintInOut(float time) {
      return time < 0.5f ? 16 * time * time * time * time * time : 1 - Mathf.Pow(-2 * time + 2, 5) / 2;
    }

    static float ExpoIn(float time) {
      return time == 0 ? 0 : Mathf.Pow(2, 10 * time - 10);
    }

    static float ExpoOut(float time) {
      return time == 1 ? 1 : 1 - Mathf.Pow(2, -10 * time);
    }

    static float ExpoInOut(float time) {
      return time == 0 ? 0 : time == 1 ? 1 : time < 0.5 ? Mathf.Pow(2, 20 * time - 10) / 2 : (2 - Mathf.Pow(2, -20 * time + 10)) / 2;
    }

    static float CircIn(float time) {
      return 1 - Mathf.Sqrt(1 - Mathf.Pow(time, 2));
    }

    static float CircOut(float time) {
      return Mathf.Sqrt(1 - Mathf.Pow(time - 1, 2));
    }

    static float CircInOut(float time) {
      return time < 0.5 ? (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * time, 2))) / 2 : (Mathf.Sqrt(1 - Mathf.Pow(-2 * time + 2, 2)) + 1) / 2;
    }

    static float BackIn(float time) {
      return constantC * time * time * time - constantA * time * time;
    }

    static float BackOut(float time) {
      return 1f + constantC * Mathf.Pow(time - 1, 3) + constantA * Mathf.Pow(time - 1, 2);
    }

    static float BackInOut(float time) {
      return time < 0.5 ?
        (Mathf.Pow(2 * time, 2) * ((constantB + 1) * 2 * time - constantB)) / 2 :
        (Mathf.Pow(2 * time - 2, 2) * ((constantB + 1) * (time * 2 - 2) + constantB) + 2) / 2;
    }

    static float ElasticIn(float time) {
      return time == 0 ? 0 : time == 1 ? 1 : -Mathf.Pow(2, 10 * time - 10) * Mathf.Sin((time * 10f - 10.75f) * constantD);
    }

    static float ElasticOut(float time) {
      return time == 0 ? 0 : time == 1 ? 1 : Mathf.Pow(2, -10 * time) * Mathf.Sin((time * 10 - 0.75f) * constantD) + 1;
    }

    static float ElasticInOut(float time) {
      return time == 0 ? 0 : time == 1 ? 1 : time < 0.5 ? -(Mathf.Pow(2, 20 * time - 10) * Mathf.Sin((20 * time - 11.125f) * constantE)) / 2 : (Mathf.Pow(2, -20 * time + 10) * Mathf.Sin((20 * time - 11.125f) * constantE)) / 2 + 1;
    }

    static float BounceIn(float time) {
      return 1 - Easer.BounceOut(1 - time);
    }

    static float BounceOut(float time) {
      if (time < 1 / constantG)
        return constantF * time * time;
      else if (time < 2 / constantG)
        return constantF * (time -= 1.5f / constantG) * time + 0.75f;
      else if (time < 2.5f / constantG)
        return constantF * (time -= 2.25f / constantG) * time + 0.9375f;
      else
        return constantF * (time -= 2.625f / constantG) * time + 0.984375f;
    }

    static float BounceInOut(float time) {
      return time < 0.5f ? (1 - Easer.BounceOut(1 - 2 * time)) / 2 : (1 + Easer.BounceOut(2 * time - 1)) / 2;
    }
  }
}