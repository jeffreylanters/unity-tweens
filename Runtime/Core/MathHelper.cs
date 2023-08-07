using UnityEngine;

namespace Tweens.Core {
  internal static class MathHelper {
    const float ConstantA = 1.70158f;
    const float ConstantB = ConstantA * 1.525f;
    const float ConstantC = ConstantA + 1f;
    const float ConstantD = (2f * Mathf.PI) / 3f;
    const float ConstantE = (2f * Mathf.PI) / 4.5f;
    const float ConstantF = 7.5625f;
    const float ConstantG = 2.75f;

    internal static float EaseTime(EaseType ease, float time) {
      return ease switch {
        EaseType.Linear => Linear(time),
        EaseType.SineIn => SineIn(time),
        EaseType.SineOut => SineOut(time),
        EaseType.SineInOut => SineInOut(time),
        EaseType.QuadIn => QuadIn(time),
        EaseType.QuadOut => QuadOut(time),
        EaseType.QuadInOut => QuadInOut(time),
        EaseType.CubicIn => CubicIn(time),
        EaseType.CubicOut => CubicOut(time),
        EaseType.CubicInOut => CubicInOut(time),
        EaseType.QuartIn => QuartIn(time),
        EaseType.QuartOut => QuartOut(time),
        EaseType.QuartInOut => QuartInOut(time),
        EaseType.QuintIn => QuintIn(time),
        EaseType.QuintOut => QuintOut(time),
        EaseType.QuintInOut => QuintInOut(time),
        EaseType.ExpoIn => ExpoIn(time),
        EaseType.ExpoOut => ExpoOut(time),
        EaseType.ExpoInOut => ExpoInOut(time),
        EaseType.CircIn => CircIn(time),
        EaseType.CircOut => CircOut(time),
        EaseType.CircInOut => CircInOut(time),
        EaseType.BackIn => BackIn(time),
        EaseType.BackOut => BackOut(time),
        EaseType.BackInOut => BackInOut(time),
        EaseType.ElasticIn => ElasticIn(time),
        EaseType.ElasticOut => ElasticOut(time),
        EaseType.ElasticInOut => ElasticInOut(time),
        EaseType.BounceIn => BounceIn(time),
        EaseType.BounceOut => BounceOut(time),
        EaseType.BounceInOut => BounceInOut(time),
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
      return ConstantC * time * time * time - ConstantA * time * time;
    }

    static float BackOut(float time) {
      return 1f + ConstantC * Mathf.Pow(time - 1, 3) + ConstantA * Mathf.Pow(time - 1, 2);
    }

    static float BackInOut(float time) {
      return time < 0.5 ?
        (Mathf.Pow(2 * time, 2) * ((ConstantB + 1) * 2 * time - ConstantB)) / 2 :
        (Mathf.Pow(2 * time - 2, 2) * ((ConstantB + 1) * (time * 2 - 2) + ConstantB) + 2) / 2;
    }

    static float ElasticIn(float time) {
      return time == 0 ? 0 : time == 1 ? 1 : -Mathf.Pow(2, 10 * time - 10) * Mathf.Sin((time * 10f - 10.75f) * ConstantD);
    }

    static float ElasticOut(float time) {
      return time == 0 ? 0 : time == 1 ? 1 : Mathf.Pow(2, -10 * time) * Mathf.Sin((time * 10 - 0.75f) * ConstantD) + 1;
    }

    static float ElasticInOut(float time) {
      return time == 0 ? 0 : time == 1 ? 1 : time < 0.5 ? -(Mathf.Pow(2, 20 * time - 10) * Mathf.Sin((20 * time - 11.125f) * ConstantE)) / 2 : (Mathf.Pow(2, -20 * time + 10) * Mathf.Sin((20 * time - 11.125f) * ConstantE)) / 2 + 1;
    }

    static float BounceIn(float time) {
      return 1 - BounceOut(1 - time);
    }

    static float BounceOut(float time) {
      if (time < 1 / ConstantG)
        return ConstantF * time * time;
      else if (time < 2 / ConstantG)
        return ConstantF * (time -= 1.5f / ConstantG) * time + 0.75f;
      else if (time < 2.5f / ConstantG)
        return ConstantF * (time -= 2.25f / ConstantG) * time + 0.9375f;
      else
        return ConstantF * (time -= 2.625f / ConstantG) * time + 0.984375f;
    }

    static float BounceInOut(float time) {
      return time < 0.5f ? (1 - BounceOut(1 - 2 * time)) / 2 : (1 + BounceOut(2 * time - 1)) / 2;
    }
  }
}