using System;
using UnityEngine;
using UnityEngine.UI;

namespace UnityPackages.Tweens {
  public static class TweenExtensions {
    public static Tween<Vector3> TweenMove (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalPositionTween> ().Finalize (duration, to);
    public static Tween<Vector3> TweenMove (this Component self, Vector3 to, float duration) =>
      self.gameObject.AddComponent<LocalPositionTween> ().Finalize (duration, to);

    public static Tween<float> TweenMoveX (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalPositionXTween> ().Finalize (duration, to);
    public static Tween<float> TweenMoveX (this Component self, float to, float duration) =>
      self.gameObject.AddComponent<LocalPositionXTween> ().Finalize (duration, to);

    public static Tween<float> TweenMoveY (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalPositionYTween> ().Finalize (duration, to);
    public static Tween<float> TweenMoveY (this Component self, float to, float duration) =>
      self.gameObject.AddComponent<LocalPositionYTween> ().Finalize (duration, to);

    public static Tween<float> TweenMoveZ (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalPositionZTween> ().Finalize (duration, to);
    public static Tween<float> TweenMoveZ (this Component self, float to, float duration) =>
      self.gameObject.AddComponent<LocalPositionZTween> ().Finalize (duration, to);

    public static Tween<Vector3> TweenRotate (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalEulerAnglesTween> ().Finalize (duration, to);
    public static Tween<Vector3> TweenRotate (this Component self, Vector3 to, float duration) =>
      self.gameObject.AddComponent<LocalEulerAnglesTween> ().Finalize (duration, to);

    public static Tween<float> TweenRotateX (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalEulerAnglesXTween> ().Finalize (duration, to);
    public static Tween<float> TweenRotateX (this Component self, float to, float duration) =>
      self.gameObject.AddComponent<LocalEulerAnglesXTween> ().Finalize (duration, to);

    public static Tween<float> TweenRotateY (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalEulerAnglesYTween> ().Finalize (duration, to);
    public static Tween<float> TweenRotateY (this Component self, float to, float duration) =>
      self.gameObject.AddComponent<LocalEulerAnglesYTween> ().Finalize (duration, to);

    public static Tween<float> TweenRotateZ (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalEulerAnglesZTween> ().Finalize (duration, to);
    public static Tween<float> TweenRotateZ (this Component self, float to, float duration) =>
      self.gameObject.AddComponent<LocalEulerAnglesZTween> ().Finalize (duration, to);

    public static Tween<Vector3> TweenScale (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalScaleTween> ().Finalize (duration, to);
    public static Tween<Vector3> TweenScale (this Component self, Vector3 to, float duration) =>
      self.gameObject.AddComponent<LocalScaleTween> ().Finalize (duration, to);

    public static Tween<float> TweenScaleX (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalScaleXTween> ().Finalize (duration, to);
    public static Tween<float> TweenScaleX (this Component self, float to, float duration) =>
      self.gameObject.AddComponent<LocalScaleXTween> ().Finalize (duration, to);

    public static Tween<float> TweenScaleY (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalScaleYTween> ().Finalize (duration, to);
    public static Tween<float> TweenScaleY (this Component self, float to, float duration) =>
      self.gameObject.AddComponent<LocalScaleYTween> ().Finalize (duration, to);

    public static Tween<float> TweenScaleZ (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalScaleZTween> ().Finalize (duration, to);
    public static Tween<float> TweenScaleZ (this Component self, float to, float duration) =>
      self.gameObject.AddComponent<LocalScaleZTween> ().Finalize (duration, to);

    public static Tween<float> TweenGraphicAlpha (this GameObject self, float to, float duration) =>
      self.AddComponent<GraphicAlphaTween> ().Finalize (duration, to);
    public static Tween<float> TweenGraphicAlpha (this Graphic self, float to, float duration) =>
      self.gameObject.AddComponent<GraphicAlphaTween> ().Finalize (duration, to);

    public static Tween<Color> TweenGraphicColor (this GameObject self, Color to, float duration) =>
      self.AddComponent<GraphicColorTween> ().Finalize (duration, to);
    public static Tween<Color> TweenGraphicColor (this Graphic self, Color to, float duration) =>
      self.gameObject.AddComponent<GraphicColorTween> ().Finalize (duration, to);

    public static Tween<float> TweenValue (this GameObject self, float to, float duration, Action<float> onUpdate) =>
      self.AddComponent<ValueTween> ().SetOnUpdate (onUpdate).Finalize (duration, to);
    public static Tween<float> TweenValue (this Component self, float to, float duration, Action<float> onUpdate) =>
      self.gameObject.AddComponent<ValueTween> ().SetOnUpdate (onUpdate).Finalize (duration, to);

    public static Tween<bool> TweenDelayedInvoke (this GameObject self, float duration, Action onComplete) =>
      self.AddComponent<DelayedInvokeTween> ().SetOnComplete (onComplete).Finalize (duration, false);
    public static Tween<bool> TweenDelayedInvoke (this Component self, float duration, Action onComplete) =>
      self.gameObject.AddComponent<DelayedInvokeTween> ().SetOnComplete (onComplete).Finalize (duration, false);
  }
}