using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class AudioSourceReverbZoneMixTween {
    public static Tween<float> TweenAudioSourceReverbZoneMix (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenAudioSourceReverbZoneMix (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float, AudioSource> {
      public override float OnGetFrom () {
        return this.component.reverbZoneMix;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.reverbZoneMix = this.valueCurrent;
      }
    }
  }
}