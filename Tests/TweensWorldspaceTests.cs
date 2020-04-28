using System;
using System.Linq;
using UnityEngine;

namespace ElRaccoone.Tweens.Tests {
  [AddComponentMenu ("El Raccoone/Tweens/Tests/World Space Tests")]
  public class TweensWorldspaceTests : MonoBehaviour {
    private Vector2 scrollPosition = new Vector2 ();

    private void OnGUI () {
      this.scrollPosition = GUILayout.BeginScrollView (this.scrollPosition, GUILayout.Width (Screen.width / 4f));

      // Flicker Testing
      GUILayout.Label ("[FLICKER TESTING]");
      if (GUILayout.Button ("Flicker testing")) {
        this.gameObject.transform.GetChild (0).gameObject.SetActive (true);
        this.gameObject.TweenLocalScale (Vector3.one, 1).SetFrom (Vector3.zero)
          .SetOnComplete (() => this.gameObject.transform.GetChild (0).gameObject.SetActive (false));
      }

      // Flicker Testing
      GUILayout.Label ("[EASE TESTING]");
      var values = Enum.GetValues (typeof (Ease)).Cast<Ease> ();
      foreach (Ease value in values)
        if (GUILayout.Button ("With Ease " + value.ToString ()))
          this.gameObject.TweenLocalPosition (new Vector3 (0, -1, 0), 1).SetFrom (new Vector3 (0, 1, 0)).SetEase (value);

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

      // if (GUILayout.Button ("Tween Value"))
      //   this.gameObject.TweenValue (50, 2, (v) => Debug.Log (v)).SetEaseSineInOut ().SetFrom (-50);
      // if (GUILayout.Button ("Tween Delayed Invoke"))
      //   this.gameObject.TweenDelayedInvoke (1, () => Debug.Log ("Hello World!"));
      // if (GUILayout.Button ("Tween Cancel"))
      //   this.gameObject.TweenCancelAll ();

      GUILayout.EndScrollView ();
    }
  }
}