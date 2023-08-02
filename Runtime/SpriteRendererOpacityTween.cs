using Tweens.Core;
using UnityEngine;

namespace Tweens {
  public sealed class SpriteRendererOpacityTween : Tween<SpriteRenderer, float> {
    public SpriteRendererOpacityTween (GameObject target) : base (target) { }

    internal sealed override float From () {
      return component.color.a;
    }

    internal sealed override float Lerp (float time) {
      return Mathf.LerpUnclamped (from, to, time);
    }

    internal sealed override void Apply (float value) {
      var color = component.color;
      color.a = value;
      component.color = color;
    }
  }
}