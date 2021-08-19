#if TWEENS_DEFINED_COM_UNITY_RENDERPIPELINES_CORE

using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace ElRaccoone.Tweens {
  public static class VolumeWeightTween {
    public static Tween<float> TweenVolumeWeight (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenVolumeWeight (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

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
