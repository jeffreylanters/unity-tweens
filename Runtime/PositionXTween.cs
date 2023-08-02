using Tweens.Core;
using UnityEngine;

namespace Tweens {
  public sealed class PositionXTween : Tween<float> {
    public PositionXTween (Component target) : base (target) { }

    internal sealed override float From () {
      return target.transform.position.x;
    }

    internal sealed override float Lerp (float time) {
      return Mathf.LerpUnclamped (from, to, time);
    }

    internal sealed override void Apply (float value) {
      var position = target.transform.position;
      position.x = value;
      target.transform.position = position;
    }
  }
}