using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens {
  public static class AudioSourcePriorityTween {
    public static Tween<float> TweenAudioSourcePriority (this Component self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    public static Tween<float> TweenAudioSourcePriority (this GameObject self, float to, float duration) =>
      Tween<float>.Add<Driver> (self).Finalize (duration, to);

    private class Driver : Tween<float, AudioSource> {
      public override float OnGetFrom () {
        return this.component.priority;
      }

      public override void OnUpdate (float easedTime) {
        this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
        this.component.priority = Mathf.RoundToInt (this.valueCurrent);
      }
    }
  }
}