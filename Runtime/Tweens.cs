using System;
using ElRaccoone.Tweens.Core;
using ElRaccoone.Tweens.TweenDrivers;
using UnityEngine;
using UnityEngine.UI;

namespace ElRaccoone.Tweens {
  public static class Tweens {
    public static TweenBase<Vector3> TweenLocalPosition (this Component self, Vector3 to, float duration) =>
      Tweens.TweenLocalPosition (self.gameObject, to, duration);
    public static TweenBase<Vector3> TweenLocalPosition (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalPositionTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenLocalPositionX (this Component self, float to, float duration) =>
      Tweens.TweenLocalPositionX (self.gameObject, to, duration);
    public static TweenBase<float> TweenLocalPositionX (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalPositionXTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenLocalPositionY (this Component self, float to, float duration) =>
      Tweens.TweenLocalPositionY (self.gameObject, to, duration);
    public static TweenBase<float> TweenLocalPositionY (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalPositionYTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenLocalPositionZ (this Component self, float to, float duration) =>
      Tweens.TweenLocalPositionZ (self.gameObject, to, duration);
    public static TweenBase<float> TweenLocalPositionZ (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalPositionZTweenDriver> ().Finalize (duration, to);

    public static TweenBase<Vector3> TweenPosition (this Component self, Vector3 to, float duration) =>
      Tweens.TweenPosition (self.gameObject, to, duration);
    public static TweenBase<Vector3> TweenPosition (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<PositionTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenPositionX (this Component self, float to, float duration) =>
      Tweens.TweenPositionX (self.gameObject, to, duration);
    public static TweenBase<float> TweenPositionX (this GameObject self, float to, float duration) =>
      self.AddComponent<PositionXTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenPositionY (this Component self, float to, float duration) =>
      Tweens.TweenPositionY (self.gameObject, to, duration);
    public static TweenBase<float> TweenPositionY (this GameObject self, float to, float duration) =>
      self.AddComponent<PositionYTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenPositionZ (this Component self, float to, float duration) =>
      Tweens.TweenPositionZ (self.gameObject, to, duration);
    public static TweenBase<float> TweenPositionZ (this GameObject self, float to, float duration) =>
      self.AddComponent<PositionZTweenDriver> ().Finalize (duration, to);

    public static TweenBase<Vector2> TweenAnchoredPosition (this Component self, Vector2 to, float duration) =>
      Tweens.TweenAnchoredPosition (self.gameObject, to, duration);
    public static TweenBase<Vector2> TweenAnchoredPosition (this GameObject self, Vector2 to, float duration) =>
      self.AddComponent<AnchoredPositionTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenAnchoredPositionX (this Component self, float to, float duration) =>
      Tweens.TweenAnchoredPositionX (self.gameObject, to, duration);
    public static TweenBase<float> TweenAnchoredPositionX (this GameObject self, float to, float duration) =>
      self.AddComponent<AnchoredPositionXTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenAnchoredPositionY (this Component self, float to, float duration) =>
      Tweens.TweenAnchoredPositionY (self.gameObject, to, duration);
    public static TweenBase<float> TweenAnchoredPositionY (this GameObject self, float to, float duration) =>
      self.AddComponent<AnchoredPositionYTweenDriver> ().Finalize (duration, to);

    public static TweenBase<Vector3> TweenLocalRotation (this Component self, Vector3 to, float duration) =>
      Tweens.TweenLocalRotation (self.gameObject, to, duration);
    public static TweenBase<Vector3> TweenLocalRotation (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalEulerAnglesTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenLocalRotationX (this Component self, float to, float duration) =>
      Tweens.TweenLocalRotationX (self.gameObject, to, duration);
    public static TweenBase<float> TweenLocalRotationX (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalEulerAnglesXTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenLocalRotationY (this Component self, float to, float duration) =>
      Tweens.TweenLocalRotationY (self.gameObject, to, duration);
    public static TweenBase<float> TweenLocalRotationY (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalEulerAnglesYTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenLocalRotationZ (this Component self, float to, float duration) =>
      Tweens.TweenLocalRotationZ (self.gameObject, to, duration);
    public static TweenBase<float> TweenLocalRotationZ (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalEulerAnglesZTweenDriver> ().Finalize (duration, to);

    public static TweenBase<Vector3> TweenRotation (this Component self, Vector3 to, float duration) =>
      Tweens.TweenRotation (self.gameObject, to, duration);
    public static TweenBase<Vector3> TweenRotation (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<EulerAnglesTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenRotationX (this Component self, float to, float duration) =>
      Tweens.TweenRotationX (self.gameObject, to, duration);
    public static TweenBase<float> TweenRotationX (this GameObject self, float to, float duration) =>
      self.AddComponent<EulerAnglesXTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenRotationY (this Component self, float to, float duration) =>
      Tweens.TweenRotationY (self.gameObject, to, duration);
    public static TweenBase<float> TweenRotationY (this GameObject self, float to, float duration) =>
      self.AddComponent<EulerAnglesYTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenRotationZ (this Component self, float to, float duration) =>
      Tweens.TweenRotationZ (self.gameObject, to, duration);
    public static TweenBase<float> TweenRotationZ (this GameObject self, float to, float duration) =>
      self.AddComponent<EulerAnglesZTweenDriver> ().Finalize (duration, to);

    public static TweenBase<Vector3> TweenLocalScale (this Component self, Vector3 to, float duration) =>
      Tweens.TweenLocalScale (self.gameObject, to, duration);
    public static TweenBase<Vector3> TweenLocalScale (this GameObject self, Vector3 to, float duration) =>
      self.AddComponent<LocalScaleTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenLocalScaleX (this Component self, float to, float duration) =>
      Tweens.TweenLocalScaleX (self.gameObject, to, duration);
    public static TweenBase<float> TweenLocalScaleX (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalScaleXTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenLocalScaleY (this Component self, float to, float duration) =>
      Tweens.TweenLocalScaleY (self.gameObject, to, duration);
    public static TweenBase<float> TweenLocalScaleY (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalScaleYTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenLocalScaleZ (this Component self, float to, float duration) =>
      Tweens.TweenLocalScaleZ (self.gameObject, to, duration);
    public static TweenBase<float> TweenLocalScaleZ (this GameObject self, float to, float duration) =>
      self.AddComponent<LocalScaleZTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenGraphicAlpha (this Component self, float to, float duration) =>
      Tweens.TweenGraphicAlpha (self.gameObject, to, duration);
    public static TweenBase<float> TweenGraphicAlpha (this GameObject self, float to, float duration) =>
      self.AddComponent<GraphicAlphaTweenDriver> ().Finalize (duration, to);

    public static TweenBase<Color> TweenGraphicColor (this Component self, Color to, float duration) =>
      Tweens.TweenGraphicColor (self.gameObject, to, duration);
    public static TweenBase<Color> TweenGraphicColor (this GameObject self, Color to, float duration) =>
      self.AddComponent<GraphicColorTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenTextMeshAlpha (this Component self, float to, float duration) =>
      Tweens.TweenTextMeshAlpha (self.gameObject, to, duration);
    public static TweenBase<float> TweenTextMeshAlpha (this GameObject self, float to, float duration) =>
      self.AddComponent<TextMeshAlphaTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenCanvasGroupAlpha (this Component self, float to, float duration) =>
      Tweens.TweenCanvasGroupAlpha (self.gameObject, to, duration);
    public static TweenBase<float> TweenCanvasGroupAlpha (this GameObject self, float to, float duration) =>
      self.AddComponent<CanvasGroupAlphaTweenDriver> ().Finalize (duration, to);

    public static TweenBase<float> TweenValue (this Component self, float to, float duration, Action<float> onUpdate) =>
      Tweens.TweenValue (self.gameObject, to, duration, onUpdate);
    public static TweenBase<float> TweenValue (this GameObject self, float to, float duration, Action<float> onUpdate) =>
      self.AddComponent<ValueTweenDriver> ().SetOnUpdate (onUpdate).Finalize (duration, to);

    public static TweenInstance TweenDelayedInvoke (this Component self, float duration, Action onComplete) =>
      Tweens.TweenDelayedInvoke (self.gameObject, duration, onComplete);
    public static TweenInstance TweenDelayedInvoke (this GameObject self, float duration, Action onComplete) =>
      self.AddComponent<DelayedInvokeTweenDriver> ().Invoke (duration, onComplete);

    public static void TweenCancelAll (this Component self, bool includeChildren = false, bool includeInactive = false) =>
      Tweens.TweenCancelAll (self.gameObject, includeChildren, includeInactive);
    public static void TweenCancelAll (this GameObject self, bool includeChildren = false, bool includeInactive = false) {
      var _tweensInstances = includeChildren == true ?
        self.GetComponentsInChildren<TweenInstance> (includeInactive) :
        self.GetComponents<TweenInstance> ();
      foreach (var _tweenInstance in _tweensInstances)
        _tweenInstance.Cancel ();
    }
  }
}