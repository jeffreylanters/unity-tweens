using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class AudioSourcePitchTween {
    public static Tween<float> TweenAudioSourcePitch (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenAudioSourcePitch (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float> {
      private AudioSource audioSource;

      public override bool OnInitialize () {
        this.audioSource = this.gameObject.GetComponent<AudioSource> ();
        return this.audioSource != null;
      }

      public override float OnGetFrom () {
        return this.audioSource.pitch;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.audioSource.pitch = this.valueCurrent;
      }
    }
  }
}