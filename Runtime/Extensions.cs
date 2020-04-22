using System;
using UnityEngine;

namespace UnityPackages.Tweens {
  public static class TweenExtensions {
    public static Tween<Vector3> TweenMove (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<PositionTween> ().Finalize (duration, to);

    public static Tween<Vector3> TweenMoveLocal (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalPositionTween> ().Finalize (duration, to);

    public static Tween<Vector3> TweenRotate (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<EulerAnglesTween> ().Finalize (duration, to);

    public static Tween<Vector3> TweenRotateLocal (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalEulerAnglesTween> ().Finalize (duration, to);

    public static Tween<Vector3> TweenScaleLocal (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalScaleTween> ().Finalize (duration, to);

    public static Tween<float> TweenValue (this GameObject self, float to, float duration, Action<float> onUpdate) =>
      self.AddComponent<ValueTween> ().SetOnUpdate (onUpdate).Finalize (duration, to);
  }
}