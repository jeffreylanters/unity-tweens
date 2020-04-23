using System;
using ElRaccoone.Tweens.Core;
using ElRaccoone.Tweens.TweenDrivers;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens {
  public static class Tweens {
    public static TweenMotor<Vector3> TweenMove (this Component self, Vector3 to, float duration) =>
      Tweens.TweenMove (self.gameObject, to, duration);
    public static TweenMotor<Vector3> TweenMove (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalPositionTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenMoveX (this Component self, float to, float duration) =>
      Tweens.TweenMoveX (self.gameObject, to, duration);
    public static TweenMotor<float> TweenMoveX (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalPositionXTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenMoveY (this Component self, float to, float duration) =>
      Tweens.TweenMoveY (self.gameObject, to, duration);
    public static TweenMotor<float> TweenMoveY (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalPositionYTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenMoveZ (this Component self, float to, float duration) =>
      Tweens.TweenMoveZ (self.gameObject, to, duration);
    public static TweenMotor<float> TweenMoveZ (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalPositionZTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<Vector2> TweenMoveAnchored (this Component self, Vector2 to, float duration) =>
      Tweens.TweenMoveAnchored (self.gameObject, to, duration);
    public static TweenMotor<Vector2> TweenMoveAnchored (this GameObject self, Vector2 to, float duration) =>
      self.AddComponent<AnchoredPositionTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenMoveAnchoredX (this Component self, float to, float duration) =>
      Tweens.TweenMoveAnchoredX (self.gameObject, to, duration);
    public static TweenMotor<float> TweenMoveAnchoredX (this GameObject self, float to, float duration) =>
      self.AddComponent<AnchoredPositionXTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenMoveAnchoredY (this Component self, float to, float duration) =>
      Tweens.TweenMoveAnchoredY (self.gameObject, to, duration);
    public static TweenMotor<float> TweenMoveAnchoredY (this GameObject self, float to, float duration) =>
      self.AddComponent<AnchoredPositionYTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<Vector3> TweenRotate (this Component self, Vector3 to, float duration) =>
      Tweens.TweenRotate (self.gameObject, to, duration);
    public static TweenMotor<Vector3> TweenRotate (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalEulerAnglesTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenRotateX (this Component self, float to, float duration) =>
      Tweens.TweenRotateX (self.gameObject, to, duration);
    public static TweenMotor<float> TweenRotateX (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalEulerAnglesXTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenRotateY (this Component self, float to, float duration) =>
      Tweens.TweenRotateY (self.gameObject, to, duration);
    public static TweenMotor<float> TweenRotateY (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalEulerAnglesYTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenRotateZ (this Component self, float to, float duration) =>
      Tweens.TweenRotateZ (self.gameObject, to, duration);
    public static TweenMotor<float> TweenRotateZ (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalEulerAnglesZTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<Vector3> TweenScale (this Component self, Vector3 to, float duration) =>
      Tweens.TweenScale (self.gameObject, to, duration);
    public static TweenMotor<Vector3> TweenScale (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalScaleTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenScaleX (this Component self, float to, float duration) =>
      Tweens.TweenScaleX (self.gameObject, to, duration);
    public static TweenMotor<float> TweenScaleX (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalScaleXTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenScaleY (this Component self, float to, float duration) =>
      Tweens.TweenScaleY (self.gameObject, to, duration);
    public static TweenMotor<float> TweenScaleY (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalScaleYTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenScaleZ (this Component self, float to, float duration) =>
      Tweens.TweenScaleZ (self.gameObject, to, duration);
    public static TweenMotor<float> TweenScaleZ (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalScaleZTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenGraphicAlpha (this GameObject self, float to, float duration) =>
      self.AddComponent<GraphicAlphaTweenDriver> ().Finalize (duration, to);
    public static TweenMotor<float> TweenGraphicAlpha (this Graphic self, float to, float duration) =>
      self.gameObject.AddComponent<GraphicAlphaTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<Color> TweenGraphicColor (this GameObject self, Color to, float duration) =>
      self.AddComponent<GraphicColorTweenDriver> ().Finalize (duration, to);
    public static TweenMotor<Color> TweenGraphicColor (this Graphic self, Color to, float duration) =>
      self.gameObject.AddComponent<GraphicColorTweenDriver> ().Finalize (duration, to);

    public static TweenMotor<float> TweenValue (this Component self, float to, float duration, Action<float> onUpdate) =>
      Tweens.TweenValue (self.gameObject, to, duration, onUpdate);
    public static TweenMotor<float> TweenValue (this GameObject self, float to, float duration, Action<float> onUpdate) =>
      self.AddComponent<ValueTweenDriver> ().SetOnUpdate (onUpdate).Finalize (duration, to);

    public static TweenBase TweenDelayedInvoke (this Component self, float duration, Action onComplete) =>
      Tweens.TweenDelayedInvoke (self.gameObject, duration, onComplete);
    public static TweenBase TweenDelayedInvoke (this GameObject self, float duration, Action onComplete) =>
      self.AddComponent<DelayedInvokeTweenDriver> ().Invoke (duration, onComplete);

    public static void TweenCancelAll (this Component self) =>
      Tweens.TweenCancelAll (self.gameObject);
    public static void TweenCancelAll (this GameObject self) {
      var _tweens = self.GetComponents<TweenBase> ();
      foreach (var _tween in _tweens)
        _tween.Cancel ();
    }
  }
}