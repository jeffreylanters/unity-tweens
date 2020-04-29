using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.TweenDrivers {
  [AddComponentMenu ("")]
  public class AudioSourcePitchTweenDriver : TweenDriver<float> {
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