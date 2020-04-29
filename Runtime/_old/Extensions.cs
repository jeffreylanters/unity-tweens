using System;
using ElRaccoone.Tweens.Core;
using ElRaccoone.Tweens.Core.Drivers;
using UnityEngine;

// namespace ElRaccoone.Tweens {
//   public static class Extensions {
//     public static Tween<Vector3> TweenLocalPosition (this Component self, Vector3 to, float duration) =>
//       Extensions.TweenLocalPosition (self.gameObject, to, duration);
//     public static Tween<Vector3> TweenLocalPosition (this GameObject self, Vector3 to, float duration) =>
//       self.AddComponent<LocalPositionTween> ().Finalize (duration, to);

//     public static Tween<float> TweenLocalPositionX (this Component self, float to, float duration) =>
//       Extensions.TweenLocalPositionX (self.gameObject, to, duration);
//     public static Tween<float> TweenLocalPositionX (this GameObject self, float to, float duration) =>
//       self.AddComponent<LocalPositionXTween> ().Finalize (duration, to);

//     public static Tween<float> TweenLocalPositionY (this Component self, float to, float duration) =>
//       Extensions.TweenLocalPositionY (self.gameObject, to, duration);
//     public static Tween<float> TweenLocalPositionY (this GameObject self, float to, float duration) =>
//       self.AddComponent<LocalPositionYTween> ().Finalize (duration, to);

//     public static Tween<float> TweenLocalPositionZ (this Component self, float to, float duration) =>
//       Extensions.TweenLocalPositionZ (self.gameObject, to, duration);
//     public static Tween<float> TweenLocalPositionZ (this GameObject self, float to, float duration) =>
//       self.AddComponent<LocalPositionZTween> ().Finalize (duration, to);

//     // public static Tween<Vector3> TweenPosition (this Component self, Vector3 to, float duration) =>
//     //   Extensions.TweenPosition (self.gameObject, to, duration);
//     // public static Tween<Vector3> TweenPosition (this GameObject self, Vector3 to, float duration) =>
//     //   self.AddComponent<PositionTween> ().Finalize (duration, to);

//     public static Tween<float> TweenPositionX (this Component self, float to, float duration) =>
//       Extensions.TweenPositionX (self.gameObject, to, duration);
//     public static Tween<float> TweenPositionX (this GameObject self, float to, float duration) =>
//       self.AddComponent<PositionXTween> ().Finalize (duration, to);

//     public static Tween<float> TweenPositionY (this Component self, float to, float duration) =>
//       Extensions.TweenPositionY (self.gameObject, to, duration);
//     public static Tween<float> TweenPositionY (this GameObject self, float to, float duration) =>
//       self.AddComponent<PositionYTween> ().Finalize (duration, to);

//     public static Tween<float> TweenPositionZ (this Component self, float to, float duration) =>
//       Extensions.TweenPositionZ (self.gameObject, to, duration);
//     public static Tween<float> TweenPositionZ (this GameObject self, float to, float duration) =>
//       self.AddComponent<PositionZTween> ().Finalize (duration, to);

//     public static Tween<Vector2> TweenAnchoredPosition (this Component self, Vector2 to, float duration) =>
//       Extensions.TweenAnchoredPosition (self.gameObject, to, duration);
//     public static Tween<Vector2> TweenAnchoredPosition (this GameObject self, Vector2 to, float duration) =>
//       self.AddComponent<AnchoredPositionTween> ().Finalize (duration, to);

//     public static Tween<float> TweenAnchoredPositionX (this Component self, float to, float duration) =>
//       Extensions.TweenAnchoredPositionX (self.gameObject, to, duration);
//     public static Tween<float> TweenAnchoredPositionX (this GameObject self, float to, float duration) =>
//       self.AddComponent<AnchoredPositionXTween> ().Finalize (duration, to);

//     public static Tween<float> TweenAnchoredPositionY (this Component self, float to, float duration) =>
//       Extensions.TweenAnchoredPositionY (self.gameObject, to, duration);
//     public static Tween<float> TweenAnchoredPositionY (this GameObject self, float to, float duration) =>
//       self.AddComponent<AnchoredPositionYTween> ().Finalize (duration, to);

//     public static Tween<Vector3> TweenLocalRotation (this Component self, Vector3 to, float duration) =>
//       Extensions.TweenLocalRotation (self.gameObject, to, duration);
//     public static Tween<Vector3> TweenLocalRotation (this GameObject self, Vector3 to, float duration) =>
//       self.AddComponent<LocalEulerAnglesTween> ().Finalize (duration, to);

//     public static Tween<float> TweenLocalRotationX (this Component self, float to, float duration) =>
//       Extensions.TweenLocalRotationX (self.gameObject, to, duration);
//     public static Tween<float> TweenLocalRotationX (this GameObject self, float to, float duration) =>
//       self.AddComponent<LocalEulerAnglesXTween> ().Finalize (duration, to);

//     public static Tween<float> TweenLocalRotationY (this Component self, float to, float duration) =>
//       Extensions.TweenLocalRotationY (self.gameObject, to, duration);
//     public static Tween<float> TweenLocalRotationY (this GameObject self, float to, float duration) =>
//       self.AddComponent<LocalEulerAnglesYTween> ().Finalize (duration, to);

//     public static Tween<float> TweenLocalRotationZ (this Component self, float to, float duration) =>
//       Extensions.TweenLocalRotationZ (self.gameObject, to, duration);
//     public static Tween<float> TweenLocalRotationZ (this GameObject self, float to, float duration) =>
//       self.AddComponent<LocalEulerAnglesZTween> ().Finalize (duration, to);

//     public static Tween<Vector3> TweenRotation (this Component self, Vector3 to, float duration) =>
//       Extensions.TweenRotation (self.gameObject, to, duration);
//     public static Tween<Vector3> TweenRotation (this GameObject self, Vector3 to, float duration) =>
//       self.AddComponent<EulerAnglesTween> ().Finalize (duration, to);

//     public static Tween<float> TweenRotationX (this Component self, float to, float duration) =>
//       Extensions.TweenRotationX (self.gameObject, to, duration);
//     public static Tween<float> TweenRotationX (this GameObject self, float to, float duration) =>
//       self.AddComponent<EulerAnglesXTween> ().Finalize (duration, to);

//     public static Tween<float> TweenRotationY (this Component self, float to, float duration) =>
//       Extensions.TweenRotationY (self.gameObject, to, duration);
//     public static Tween<float> TweenRotationY (this GameObject self, float to, float duration) =>
//       self.AddComponent<EulerAnglesYTween> ().Finalize (duration, to);

//     public static Tween<float> TweenRotationZ (this Component self, float to, float duration) =>
//       Extensions.TweenRotationZ (self.gameObject, to, duration);
//     public static Tween<float> TweenRotationZ (this GameObject self, float to, float duration) =>
//       self.AddComponent<EulerAnglesZTween> ().Finalize (duration, to);

//     public static Tween<Vector3> TweenLocalScale (this Component self, Vector3 to, float duration) =>
//       Extensions.TweenLocalScale (self.gameObject, to, duration);
//     public static Tween<Vector3> TweenLocalScale (this GameObject self, Vector3 to, float duration) =>
//       self.AddComponent<LocalScaleTween> ().Finalize (duration, to);

//     public static Tween<float> TweenLocalScaleX (this Component self, float to, float duration) =>
//       Extensions.TweenLocalScaleX (self.gameObject, to, duration);
//     public static Tween<float> TweenLocalScaleX (this GameObject self, float to, float duration) =>
//       self.AddComponent<LocalScaleXTween> ().Finalize (duration, to);

//     public static Tween<float> TweenLocalScaleY (this Component self, float to, float duration) =>
//       Extensions.TweenLocalScaleY (self.gameObject, to, duration);
//     public static Tween<float> TweenLocalScaleY (this GameObject self, float to, float duration) =>
//       self.AddComponent<LocalScaleYTween> ().Finalize (duration, to);

//     public static Tween<float> TweenLocalScaleZ (this Component self, float to, float duration) =>
//       Extensions.TweenLocalScaleZ (self.gameObject, to, duration);
//     public static Tween<float> TweenLocalScaleZ (this GameObject self, float to, float duration) =>
//       self.AddComponent<LocalScaleZTween> ().Finalize (duration, to);

//     public static Tween<float> TweenGraphicAlpha (this Component self, float to, float duration) =>
//       Extensions.TweenGraphicAlpha (self.gameObject, to, duration);
//     public static Tween<float> TweenGraphicAlpha (this GameObject self, float to, float duration) =>
//       self.AddComponent<GraphicAlphaTween> ().Finalize (duration, to);

//     public static Tween<Color> TweenGraphicColor (this Component self, Color to, float duration) =>
//       Extensions.TweenGraphicColor (self.gameObject, to, duration);
//     public static Tween<Color> TweenGraphicColor (this GameObject self, Color to, float duration) =>
//       self.AddComponent<GraphicColorTween> ().Finalize (duration, to);

//     public static Tween<float> TweenImageFillAmount (this Component self, float to, float duration) =>
//       Extensions.TweenImageFillAmount (self.gameObject, to, duration);
//     public static Tween<float> TweenImageFillAmount (this GameObject self, float to, float duration) =>
//       self.AddComponent<ImageFillAmountTween> ().Finalize (duration, to);

//     public static Tween<float> TweenTextMeshAlpha (this Component self, float to, float duration) =>
//       Extensions.TweenTextMeshAlpha (self.gameObject, to, duration);
//     public static Tween<float> TweenTextMeshAlpha (this GameObject self, float to, float duration) =>
//       self.AddComponent<TextMeshAlphaTween> ().Finalize (duration, to);

//     public static Tween<float> TweenCanvasGroupAlpha (this Component self, float to, float duration) =>
//       Extensions.TweenCanvasGroupAlpha (self.gameObject, to, duration);
//     public static Tween<float> TweenCanvasGroupAlpha (this GameObject self, float to, float duration) =>
//       self.AddComponent<CanvasGroupAlphaTween> ().Finalize (duration, to);

//     public static Tween<float> TweenAudioSourceVolume (this Component self, float to, float duration) =>
//       Extensions.TweenAudioSourceVolume (self.gameObject, to, duration);
//     public static Tween<float> TweenAudioSourceVolume (this GameObject self, float to, float duration) =>
//       self.AddComponent<AudioSourceVolumeTween> ().Finalize (duration, to);

//     public static Tween<float> TweenAudioSourcePitch (this Component self, float to, float duration) =>
//       Extensions.TweenAudioSourcePitch (self.gameObject, to, duration);
//     public static Tween<float> TweenAudioSourcePitch (this GameObject self, float to, float duration) =>
//       self.AddComponent<AudioSourcePitchTween> ().Finalize (duration, to);

//     public static Tween<float> TweenValue (this Component self, float to, float duration, Action<float> onUpdate) =>
//       Extensions.TweenValue (self.gameObject, to, duration, onUpdate);
//     public static Tween<float> TweenValue (this GameObject self, float to, float duration, Action<float> onUpdate) =>
//       self.AddComponent<ValueTween> ().SetOnUpdate (onUpdate).Finalize (duration, to);

//     public static ITween TweenDelayedInvoke (this Component self, float duration, Action onComplete) =>
//       Extensions.TweenDelayedInvoke (self.gameObject, duration, onComplete);
//     public static ITween TweenDelayedInvoke (this GameObject self, float duration, Action onComplete) =>
//       self.AddComponent<DelayedInvokeTween> ().SetOnComplete (onComplete).Finalize (duration, false);

//     public static void TweenCancelAll (this Component self, bool includeChildren = false, bool includeInactive = false) =>
//       Extensions.TweenCancelAll (self.gameObject, includeChildren, includeInactive);
//     public static void TweenCancelAll (this GameObject self, bool includeChildren = false, bool includeInactive = false) {
//       var _tweensInstances = includeChildren == true ?
//         self.GetComponentsInChildren<ITween> (includeInactive) :
//         self.GetComponents<ITween> ();
//       foreach (var _tweenInstance in _tweensInstances)
//         _tweenInstance.Cancel ();
//     }
//   }
// }