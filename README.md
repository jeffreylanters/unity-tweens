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
rectTransform.TweenGraphicColor(Color.white, 1).SetFrom(Color.red).SetLoopPingPong();
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
SetLoopPingPong ();
SetLoopCount (int loopCount);
SetDelay (float delay);
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
