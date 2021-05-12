#if SRP_AVAILABLE

using ElRaccoone.Tweens.Core;
using UnityEngine;
using UnityEngine.Rendering;

namespace ElRaccoone.Tweens
{
    public static class VolumeWeightTween
    {
        public static Tween<float> TweenVolumeWeight(this Component self, float to, float duration) =>
          Tween<float>.Add<Driver>(self).Finalize(duration, to);

        public static Tween<float> TweenVolumeWeight(this GameObject self, float to, float duration) =>
          Tween<float>.Add<Driver>(self).Finalize(duration, to);

        private class Driver : Tween<float>
        {
            private Volume volume;

            public override bool OnInitialize()
            {
                this.volume = this.gameObject.GetComponent<Volume>();
                return this.volume != null;
            }

            public override float OnGetFrom()
            {
                return this.volume.weight;
            }

            public override void OnUpdate(float easedTime)
            {
                this.valueCurrent = this.InterpolateValue(this.valueFrom, this.valueTo, easedTime);
                this.volume.weight = this.valueCurrent;
            }
        }
    }
}

#endif
