using Tweens.Core;
using UnityEngine;

namespace Tweens {
  public sealed class PositionTween : Tween<Vector3> {
    public PositionTween (Component target) : base (target) { }

    internal sealed override Vector3 From () {
      return target.transform.position;
    }

    internal sealed override Vector3 Lerp (float time) {
      return Vector3.LerpUnclamped (from, to, time);
    }

    internal sealed override void Apply (Vector3 value) {
      target.transform.position = value;
    }
  }
}