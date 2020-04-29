#if UNITY_EDITOR

using System;
using System.Linq;
using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.Tests {
  [AddComponentMenu ("El Raccoone/Tweens/Tests/Tween Tests")]
  public class TweenTests : MonoBehaviour {
    private Vector2 scrollPosition = new Vector2 ();

    private void OnGUI () {
      this.scrollPosition = GUILayout.BeginScrollView (this.scrollPosition, GUILayout.Width (Screen.width / 3f));

      // Visual Tweens Testing
      GUILayout.Label ("[VISUAL TWEENS TESTING]");
      if (GUILayout.Button ("AnchoredPosition"))
        this.gameObject.TweenAnchoredPosition (new Vector2 (1, 0), 1).SetFrom (new Vector2 (-1, 0));
      if (GUILayout.Button ("AnchoredPositionX"))
        this.gameObject.TweenAnchoredPositionX (1, 1).SetFrom (0);
      if (GUILayout.Button ("AnchoredPositionY"))
        this.gameObject.TweenAnchoredPositionY (1, 1).SetFrom (0);
      if (GUILayout.Button ("AudioSourcePitch"))
        this.gameObject.TweenAudioSourcePitch (1, 1).SetFrom (0);
      if (GUILayout.Button ("AudioSourceVolume"))
        this.gameObject.TweenAudioSourceVolume (1, 1).SetFrom (0);
      if (GUILayout.Button ("CanvasGroupAlpha"))
        this.gameObject.TweenCanvasGroupAlpha (1, 1).SetFrom (0);
      if (GUILayout.Button ("EulerAngles"))
        this.gameObject.TweenRotation (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("EulerAnglesX"))
        this.gameObject.TweenRotationX (1, 1).SetFrom (0);
      if (GUILayout.Button ("EulerAnglesY"))
        this.gameObject.TweenRotationY (1, 1).SetFrom (0);
      if (GUILayout.Button ("EulerAnglesZ"))
        this.gameObject.TweenRotationZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("GraphicAlpha"))
        this.gameObject.TweenGraphicAlpha (1, 1).SetFrom (0);
      if (GUILayout.Button ("GraphicColor"))
        this.gameObject.TweenGraphicColor (Color.white, 1).SetFrom (Color.red);
      if (GUILayout.Button ("ImageFillAmount"))
        this.gameObject.TweenImageFillAmount (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalEulerAngles"))
        this.gameObject.TweenLocalRotation (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("LocalEulerAnglesX"))
        this.gameObject.TweenLocalRotationX (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalEulerAnglesY"))
        this.gameObject.TweenLocalRotationY (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalEulerAnglesZ"))
        this.gameObject.TweenLocalRotationZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("MaterialAlpha"))
        this.gameObject.TweenMaterialAlpha (1, 1).SetFrom (0);
      if (GUILayout.Button ("MaterialColor"))
        this.gameObject.TweenMaterialColor (Color.white, 1).SetFrom (Color.red);
      if (GUILayout.Button ("LocalPosition"))
        this.gameObject.TweenLocalPosition (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("LocalPositionX"))
        this.gameObject.TweenLocalPositionX (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalPositionY"))
        this.gameObject.TweenLocalPositionY (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalPositionZ"))
        this.gameObject.TweenLocalPositionZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalScale"))
        this.gameObject.TweenLocalScale (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("LocalScaleX"))
        this.gameObject.TweenLocalScaleX (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalScaleY"))
        this.gameObject.TweenLocalScaleY (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalScaleZ"))
        this.gameObject.TweenLocalScaleZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("Position"))
        this.gameObject.TweenPosition (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("PositionX"))
        this.gameObject.TweenPositionX (1, 1).SetFrom (0);
      if (GUILayout.Button ("PositionY"))
        this.gameObject.TweenPositionY (1, 1).SetFrom (0);
      if (GUILayout.Button ("PositionZ"))
        this.gameObject.TweenPositionZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("TextMeshAlpha"))
        this.gameObject.TweenTextMeshAlpha (1, 1).SetFrom (0);

      // Flicker Testing
      GUILayout.Label ("[FLICKER TESTING]");
      if (GUILayout.Button ("Flicker testing")) {
        this.gameObject.transform.GetChild (0).gameObject.SetActive (true);
        this.gameObject.TweenLocalScale (Vector3.one, 1).SetFrom (Vector3.zero)
          .SetOnComplete (() => this.gameObject.transform.GetChild (0).gameObject.SetActive (false));
      }

      // Delay Testing
      GUILayout.Label ("[DELAY TESTING]");
      if (GUILayout.Button ("Scale"))
        this.gameObject.TweenLocalScale (Vector3.one, 1).SetFrom (Vector3.one * .5f);
      if (GUILayout.Button ("Scale Delay(1)"))
        this.gameObject.TweenLocalScale (Vector3.one, 1).SetDelay (1).SetFrom (Vector3.one * .5f);
      if (GUILayout.Button ("Scale Delay(1,true)"))
        this.gameObject.TweenLocalScale (Vector3.one, 1).SetDelay (1, true).SetFrom (Vector3.one * .5f);

      // Ease Testing
      GUILayout.Label ("[EASE TESTING]");
      var values = Enum.GetValues (typeof (EaseType)).Cast<EaseType> ();
      foreach (EaseType value in values)
        if (GUILayout.Button ("With Ease " + value.ToString ())) {
          this.gameObject.transform.localPosition = new Vector3 (0, 1, 0);
          this.gameObject.TweenLocalPosition (new Vector3 (0, -1, 0), 2).SetEase (value).SetDelay (.5f);
        }

      // Flicker Testing
      GUILayout.Label ("[ROTATION TESTING]");
      GUILayout.Label ("Curr. Z:" + this.gameObject.transform.eulerAngles.z);
      if (GUILayout.Button ("Rotation 350"))
        this.gameObject.TweenRotationZ (350, 2).SetEaseSineInOut ();
      if (GUILayout.Button ("Rotation -20"))
        this.gameObject.TweenRotationZ (-20, 2).SetEaseSineInOut ();
      if (GUILayout.Button ("Rotation 20"))
        this.gameObject.TweenRotationZ (20, 2).SetEaseSineInOut ();

      // LOOPCOUNT/INFINITE & PINGPONG
      GUILayout.Label ("[LOOPCOUNT/INFINITE & PINGPONG]");
      if (GUILayout.Button ("PositionX:0"))
        this.gameObject.TweenPositionX (0, .2f);
      if (GUILayout.Button ("PositionX:5"))
        this.gameObject.TweenPositionX (5, 0.5f);
      if (GUILayout.Button ("PositionX:5 LoopCount:1"))
        this.gameObject.TweenPositionX (5, 0.5f).SetLoopCount (1).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 LoopCount:2"))
        this.gameObject.TweenPositionX (5, 0.5f).SetLoopCount (2).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 LoopCount:4"))
        this.gameObject.TweenPositionX (5, 0.5f).SetLoopCount (4).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 Infinite"))
        this.gameObject.TweenPositionX (5, 0.5f).SetInfinite ().SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong"))
        this.gameObject.TweenPositionX (5, 0.5f).SetPingPong ().SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong LoopCount:1"))
        this.gameObject.TweenPositionX (5, 0.5f).SetPingPong ().SetLoopCount (1).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong LoopCount:2"))
        this.gameObject.TweenPositionX (5, 0.5f).SetPingPong ().SetLoopCount (2).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong LoopCount:4"))
        this.gameObject.TweenPositionX (5, 0.5f).SetPingPong ().SetLoopCount (4).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong Infinite"))
        this.gameObject.TweenPositionX (5, 0.5f).SetPingPong ().SetInfinite ().SetEaseSineInOut ();

      // Misc Testing
      GUILayout.Label ("[MISC TESTING]");
      if (GUILayout.Button ("Tween Value"))
        this.gameObject.TweenValue (50, 2, (v) => Debug.Log (v)).SetEaseSineInOut ().SetFrom (-50);
      if (GUILayout.Button ("Tween Delayed Invoke"))
        this.gameObject.TweenDelayedInvoke (1, () => Debug.Log ("Hello World!"));

      // Flicker Testing
      GUILayout.Label ("[CANCELING TESTING]");
      if (GUILayout.Button ("TweenScale"))
        this.gameObject.TweenLocalScaleX (1, 5).SetFrom (0);
      if (GUILayout.Button ("TweenScale With OnCancel"))
        this.gameObject.TweenLocalScaleX (1, 5).SetFrom (0).SetOnCancel (() => Debug.Log ("Did Cancel"));
      if (GUILayout.Button ("CancelAll"))
        this.gameObject.TweenCancelAll ();

      GUILayout.EndScrollView ();
    }
  }
}

#endif