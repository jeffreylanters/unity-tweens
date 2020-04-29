using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class AudioSourceVolumeTween {
    public static Tween<float> TweenAudioSourceVolume (this Component self, float to, float duration) =>
      self.gameObject.TweenAudioSourceVolume (to, duration);

    public static Tween<float> TweenAudioSourceVolume (this GameObject self, float to, float duration) =>
      self.AddComponent<Tween> ().Finalize (duration, to);

    private class Tween : Tween<float> {
      private AudioSource audioSource;

      public override bool OnInitialize () {
        this.audioSource = this.gameObject.GetComponent<AudioSource> ();
        return this.audioSource != null;
      }

      public override float OnGetFrom () {
        return this.audioSource.volume;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.audioSource.volume = this.valueCurrent;
      }
    }
  }
}