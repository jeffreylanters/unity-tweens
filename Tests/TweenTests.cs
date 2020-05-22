#if UNITY_EDITOR

using System;
using System.Linq;
using ElRaccoone.Tweens.Core;
using UnityEngine;

namespace ElRaccoone.Tweens.Tests {
  [AddComponentMenu ("El Raccoone/Tweens/Tests/Tween Tests")]
  public class TweenTests : MonoBehaviour {
    public GameObject target;

    private Vector2 scrollPosition = new Vector2 ();

    private void OnGUI () {
      this.scrollPosition = GUILayout.BeginScrollView (this.scrollPosition, GUILayout.Width (Screen.width / 3f));

      // TEMP
      if (GUILayout.Button ("TEMP"))
        this.target.TweenPositionY (3, 5).SetShouldDecommissionOnDisable (false);

      // Visual Tweens Testing
      GUILayout.Label ("[VISUAL TWEENS TESTING]");
      if (GUILayout.Button ("AnchoredPosition"))
        this.target.TweenAnchoredPosition (new Vector2 (1, 0), 1).SetFrom (new Vector2 (-1, 0));
      if (GUILayout.Button ("AnchoredPositionX"))
        this.target.TweenAnchoredPositionX (1, 1).SetFrom (0);
      if (GUILayout.Button ("AnchoredPositionY"))
        this.target.TweenAnchoredPositionY (1, 1).SetFrom (0);
      if (GUILayout.Button ("AudioSourcePitch"))
        this.target.TweenAudioSourcePitch (1, 1).SetFrom (0);
      if (GUILayout.Button ("AudioSourceVolume"))
        this.target.TweenAudioSourceVolume (1, 1).SetFrom (0);
      if (GUILayout.Button ("CanvasGroupAlpha"))
        this.target.TweenCanvasGroupAlpha (1, 1).SetFrom (0);
      if (GUILayout.Button ("EulerAngles"))
        this.target.TweenRotation (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("EulerAnglesX"))
        this.target.TweenRotationX (1, 1).SetFrom (0);
      if (GUILayout.Button ("EulerAnglesY"))
        this.target.TweenRotationY (1, 1).SetFrom (0);
      if (GUILayout.Button ("EulerAnglesZ"))
        this.target.TweenRotationZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("GraphicAlpha"))
        this.target.TweenGraphicAlpha (1, 1).SetFrom (0);
      if (GUILayout.Button ("GraphicColor"))
        this.target.TweenGraphicColor (Color.white, 1).SetFrom (Color.red);
      if (GUILayout.Button ("ImageFillAmount"))
        this.target.TweenImageFillAmount (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalEulerAngles"))
        this.target.TweenLocalRotation (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("LocalEulerAnglesX"))
        this.target.TweenLocalRotationX (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalEulerAnglesY"))
        this.target.TweenLocalRotationY (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalEulerAnglesZ"))
        this.target.TweenLocalRotationZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("MaterialAlpha"))
        this.target.TweenMaterialAlpha (1, 1).SetFrom (0);
      if (GUILayout.Button ("MaterialColor"))
        this.target.TweenMaterialColor (Color.white, 1).SetFrom (Color.red);
      if (GUILayout.Button ("LocalPosition"))
        this.target.TweenLocalPosition (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("LocalPositionX"))
        this.target.TweenLocalPositionX (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalPositionY"))
        this.target.TweenLocalPositionY (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalPositionZ"))
        this.target.TweenLocalPositionZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalScale"))
        this.target.TweenLocalScale (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("LocalScaleX"))
        this.target.TweenLocalScaleX (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalScaleY"))
        this.target.TweenLocalScaleY (1, 1).SetFrom (0);
      if (GUILayout.Button ("LocalScaleZ"))
        this.target.TweenLocalScaleZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("Position"))
        this.target.TweenPosition (Vector3.one, 1).SetFrom (Vector3.zero);
      if (GUILayout.Button ("PositionX"))
        this.target.TweenPositionX (1, 1).SetFrom (0);
      if (GUILayout.Button ("PositionY"))
        this.target.TweenPositionY (1, 1).SetFrom (0);
      if (GUILayout.Button ("PositionZ"))
        this.target.TweenPositionZ (1, 1).SetFrom (0);
      if (GUILayout.Button ("SpriteRendererAlpha"))
        this.target.TweenSpriteRendererAlpha (1, 1).SetFrom (0);
      if (GUILayout.Button ("SpriteRendererColor"))
        this.target.TweenSpriteRendererColor (Color.white, 1).SetFrom (Color.red);
      if (GUILayout.Button ("TextMeshAlpha"))
        this.target.TweenTextMeshAlpha (1, 1).SetFrom (0);

      // Flicker Testing
      GUILayout.Label ("[FLICKER TESTING]");
      if (GUILayout.Button ("Flicker testing")) {
        this.target.transform.GetChild (0).gameObject.SetActive (true);
        this.target.TweenLocalScale (Vector3.one, 1).SetFrom (Vector3.zero)
          .SetOnComplete (() => this.target.transform.GetChild (0).gameObject.SetActive (false));
      }

      // Delay Testing
      GUILayout.Label ("[DELAY TESTING]");
      if (GUILayout.Button ("Scale"))
        this.target.TweenLocalScale (Vector3.one, 1).SetFrom (Vector3.one * .5f);
      if (GUILayout.Button ("Scale Delay(1)"))
        this.target.TweenLocalScale (Vector3.one, 1).SetDelay (1).SetFrom (Vector3.one * .5f);
      if (GUILayout.Button ("Scale Delay(1,true)"))
        this.target.TweenLocalScale (Vector3.one, 1).SetDelay (1, true).SetFrom (Vector3.one * .5f);

      // Ease Testing
      GUILayout.Label ("[EASE TESTING]");
      var values = Enum.GetValues (typeof (EaseType)).Cast<EaseType> ();
      foreach (EaseType value in values)
        if (GUILayout.Button ("With Ease " + value.ToString ())) {
          this.target.transform.localPosition = new Vector3 (0, 1, 0);
          this.target.TweenLocalPosition (new Vector3 (0, -1, 0), 2).SetEase (value).SetDelay (.5f);
        }

      // Flicker Testing
      GUILayout.Label ("[ROTATION TESTING]");
      GUILayout.Label ("Curr. Z:" + this.target.transform.eulerAngles.z);
      if (GUILayout.Button ("Rotation 350"))
        this.target.TweenRotationZ (350, 2).SetEaseSineInOut ();
      if (GUILayout.Button ("Rotation -20"))
        this.target.TweenRotationZ (-20, 2).SetEaseSineInOut ();
      if (GUILayout.Button ("Rotation 20"))
        this.target.TweenRotationZ (20, 2).SetEaseSineInOut ();

      // LOOPCOUNT/INFINITE & PINGPONG
      GUILayout.Label ("[LOOPCOUNT/INFINITE & PINGPONG]");
      if (GUILayout.Button ("PositionX:0"))
        this.target.TweenPositionX (0, .2f);
      if (GUILayout.Button ("PositionX:5"))
        this.target.TweenPositionX (5, 0.5f);
      if (GUILayout.Button ("PositionX:5 LoopCount:1"))
        this.target.TweenPositionX (5, 0.5f).SetLoopCount (1).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 LoopCount:2"))
        this.target.TweenPositionX (5, 0.5f).SetLoopCount (2).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 LoopCount:4"))
        this.target.TweenPositionX (5, 0.5f).SetLoopCount (4).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 Infinite"))
        this.target.TweenPositionX (5, 0.5f).SetInfinite ().SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong"))
        this.target.TweenPositionX (5, 0.5f).SetPingPong ().SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong LoopCount:1"))
        this.target.TweenPositionX (5, 0.5f).SetPingPong ().SetLoopCount (1).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong LoopCount:2"))
        this.target.TweenPositionX (5, 0.5f).SetPingPong ().SetLoopCount (2).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong LoopCount:4"))
        this.target.TweenPositionX (5, 0.5f).SetPingPong ().SetLoopCount (4).SetEaseSineInOut ();
      if (GUILayout.Button ("PositionX:5 SetPingPong Infinite"))
        this.target.TweenPositionX (5, 0.5f).SetPingPong ().SetInfinite ().SetEaseSineInOut ();

      // Misc Testing
      GUILayout.Label ("[MISC TESTING]");
      if (GUILayout.Button ("Tween Value"))
        this.target.TweenValue (50, 2, (v) => Debug.Log (v)).SetEaseSineInOut ().SetFrom (-50);
      if (GUILayout.Button ("Tween Delayed Invoke"))
        this.target.TweenDelayedInvoke (1, () => Debug.Log ("Hello World!"));

      // Flicker Testing
      GUILayout.Label ("[CANCELING TESTING]");
      if (GUILayout.Button ("TweenScale"))
        this.target.TweenLocalScaleX (1, 5).SetFrom (0);
      if (GUILayout.Button ("TweenScale With OnCancel"))
        this.target.TweenLocalScaleX (1, 5).SetFrom (0).SetOnCancel (() => Debug.Log ("Did Cancel"));
      if (GUILayout.Button ("CancelAll"))
        this.target.TweenCancelAll ();

      GUILayout.EndScrollView ();
    }
  }
}

#endif