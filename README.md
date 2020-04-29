<div align="center">

<img src="https://raw.githubusercontent.com/elraccoone/unity-tweens/master/.github/WIKI/logo.jpg" height="100px"></br>

# Tweens

[![npm](https://img.shields.io/badge/upm-1.4.0-232c37.svg?style=for-the-badge)]()
[![license](https://img.shields.io/badge/license-Custom-%23ecc531.svg?style=for-the-badge)](./LICENSE.md)
[![npm](https://img.shields.io/badge/sponsor-donate-E12C9A.svg?style=for-the-badge)](https://paypal.me/jeffreylanters)
[![npm](https://img.shields.io/github/stars/elraccoone/unity-tweens.svg?style=for-the-badge)]()

An extremely light weight, extendable and customisable tweening engine made for script-based animations for user-interfaces and world-spaces objects optimised for all platforms.

The power and speed you expect get other tweening engines, but better, with strictly typed methods and clean and ease-to-use forward methods for all use cases.

When using this Unity Package, make sure to **Star** this repository. When using any of the packages please make sure to give credits to **Jeffrey Lanters / El Raccoone** somewhere in your app or game. **It it prohibited to distribute, sublicense, and/or sell copies of the Software!**

**&Lt;**
[**Installation**](#installation) &middot;
[**Documentation**](#documentation) &middot;
[**License**](./LICENSE.md) &middot;
[**Sponsor**](https://paypal.me/jeffreylanters)
**&Gt;**

**Made with &hearts; by Jeffrey Lanters**

</div>

## Installation

Install using the Unity Package Manager. add the following line to your `manifest.json` file located within your project's packages directory.

```json
"nl.elraccoone.tweens": "git+https://github.com/elraccoone/unity-tweens"
```

## Documentation

### Examples

```cs
using ElRaccoone.Tweens;
transform.TweenPosition(new Vector3(10, 20, 30), 2);
gameObject.TweenLocalRotationX(100, 1).SetFrom(-20).SetLoopCount(2).SetEaseQuadIn();
rectTransform.TweenGraphicColor(Color.white, 1).SetFrom(Color.red).SetPingPong().SetInfinite();
image.TweenLocalScale(new Vector3(2, 2, 2), 2).SetEaseBackOut().SetOvershooting(0.5f);
gameObject.TweenValue(100, 1, (value) => { /* ... */ }).SetFrom(10).SetEase(Ease.QuadOut);
transform.TweenCancelAll();
```

### Methods

Tweens expose a various number of methods, these are presented in **Extention methods** for **GameObjects** and any **Component**. _Feel free to request more properties to tween_.

```cs
TweenLocalPosition (Vector3 to, float duration);
TweenLocalPositionX (float to, float duration);
TweenLocalPositionY (float to, float duration);
TweenLocalPositionZ (float to, float duration);
TweenPosition (Vector3 to, float duration);
TweenPositionX (float to, float duration);
TweenPositionY (float to, float duration);
TweenPositionZ (float to, float duration);
TweenAnchoredPosition (Vector2 to, float duration);
TweenAnchoredPositionX (float to, float duration);
TweenAnchoredPositionY (float to, float duration);
TweenLocalRotation (Vector3 to, float duration);
TweenLocalRotationX (float to, float duration);
TweenLocalRotationY (float to, float duration);
TweenLocalRotationZ (float to, float duration);
TweenRotation (Vector3 to, float duration);
TweenRotationX (float to, float duration);
TweenRotationY (float to, float duration);
TweenRotationZ (float to, float duration);
TweenLocalScale (Vector3 to, float duration);
TweenLocalScaleX (float to, float duration);
TweenLocalScaleY (float to, float duration);
TweenLocalScaleZ (float to, float duration);
TweenGraphicAlpha (float to, float duration);
TweenGraphicColor (Color to, float duration);
TweenImageFillAmount (float to, float duration);
TweenTextMeshAlpha (float to, float duration);
TweenCanvasGroupAlpha (float to, float duration);
TweenAudioSourceVolume (float to, float duration);
TweenAudioSourcePitch (float to, float duration);
TweenValue (float to, float duration, Action<float> onUpdate);
TweenDelayedInvoke(float duration, Action onComplete);
TweenCancelAll (bool includeChildren = false, bool includeInactive = false);
```

### Option Chaining

When invoking a tween as show above, various options can be changed using chaining methods.

```cs
SetFrom (T valueFrom);
SetOnComplete (Action onComplete);
SetOnCancel (Action onCancel);
SetPingPong ();
SetLoopCount (int loopCount);
SetInfinite ();
SetDelay (float delay, bool goToFirstFrameImmediately = false);
SetRandomStartTime ();
SetOvershooting (float overshooting);
SetEase (Ease ease);
SetEaseLinear ();
SetEaseSineIn ();
SetEaseSineOut ();
SetEaseSineInOut ();
SetEaseQuadIn ();
SetEaseQuadOut ();
SetEaseQuadInOut ();
SetEaseCubicIn ();
SetEaseCubicOut ();
SetEaseCubicInOut ();
SetEaseQuartIn ();
SetEaseQuartOut ();
SetEaseQuartInOut ();
SetEaseQuintIn ();
SetEaseQuintOut ();
SetEaseQuintInOut ();
SetEaseExpoIn ();
SetEaseExpoOut ();
SetEaseExpoInOut ();
SetEaseCircIn ();
SetEaseCircOut ();
SetEaseCircInOut ();
SetEaseBackIn ();
SetEaseBackOut ();
SetEaseBackInOut ();
SetEaseElasticIn ();
SetEaseElasticOut ();
SetEaseElasticInOut ();
SetEaseBounceIn ();
SetEaseBounceOut ();
SetEaseBounceInOut ()
```

### Or just write your own using the Tweens Core!

In this example we'll write an TextMeshPro alpha tween.

```cs
// Start by adding imports to our newly created 'TextMeshProAlphaTween.cs'
using ElRaccoone.Tweens.Core;
using UnityEngine;

// First we'll create a static class containing all the methods and classes.
public static class TextMeshProAlphaTween {

  // Add Extensions methods to your class so you can invoke this tween on any
  // type you would like to use your new tween.
  public static Tween<float> TweenTextMeshProAlpha (this TextMeshPro self, float to, float duration) =>
    self.gameObject.AddComponent<Tween> ().Finalize (duration, to);

  // Next up we'll create a private class extending from the generic tween class.
  // Our generic will represent the value we're tweening. This should be the same
  // type as our 'to' parameter defined in our extention method.
  private class Tween : Tween<float> {

    // In this example we'll create a reference to our TextMeshPro.
    private TextMeshPro textMeshPro;

    // The core will invoke 'OnInitialize' first, here you can do your
    // initialization. Return 'true' when the tween should play, or false
    // when something is wrong like a missing component so the tween aborts.
    public override bool OnInitialize () {
      this.textMeshPro = this.gameObject.GetComponent<TextMeshPro> ();
      return this.textMeshPro != null;
    }

    // The core will invoke 'OnGetFrom' next, right after the initialize or
    // after the start delay depending on your tweens options. You should return
    // your start value.
    public override float OnGetFrom () {
      return this.textMeshPro.alpha;
    }

    // The core will invoke 'OnUpdate' every frame of your animation. The
    // easedTime can be used for your animation. Use the InterpolateValue
    // method to clamp your value between the 'from' and 'to'.
    public override void OnUpdate (float easedTime) {
      this.valueCurrent = this.InterpolateValue (this.valueFrom, this.valueTo, easedTime);
      this.textMeshPro.alpha = this.valueCurrent;
    }
  }
}
```

Now you're ready to use your tween!

```cs
public class Test : MonoBehaviour {
  public void Start () {
    this.myTmp.TweenTextMeshProAlpha (1, 2.5f).SetFrom(0).SetEaseBackIn().SetDelay(1);
  }
}
```
