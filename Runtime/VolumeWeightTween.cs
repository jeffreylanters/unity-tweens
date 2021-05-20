#if TWEENS_RENDER_PIPELINES_CORE

using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace ElRaccoone.Tweens {
  public static class VolumeWeightTween {
    public static Tween<float> TweenVolumeWeight (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenVolumeWeight (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float, Volume> {
      public override float OnGetFrom () {
        return this.component.weight;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.weight = this.valueCurrent;
      }
    }
  }
}

#endif
