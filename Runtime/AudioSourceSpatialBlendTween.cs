using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class AudioSourceSpatialBlendTween {
    public static Tween<float> TweenAudioSourceSpatialBlend (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    public static Tween<float> TweenAudioSourceSpatialBlend (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (to, duration);

    private class Driver : Tween<float, AudioSource> {
      public override float OnGetFrom () {
        return this.component.spatialBlend;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.spatialBlend = this.valueCurrent;
      }
    }
  }
}