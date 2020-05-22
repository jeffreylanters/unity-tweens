<div align="center">

<img src="https://raw.githubusercontent.com/elraccoone/unity-tweens/master/.github/WIKI/logo.jpg" height="100px"></br>

# Tweens

[![npm](https://img.shields.io/badge/upm-1.5.0-232c37.svg?style=for-the-badge)]()
[![license](https://img.shields.io/badge/license-Custom-%23ecc531.svg?style=for-the-badge)](./LICENSE.md)
[![npm](https://img.shields.io/badge/sponsor-donate-E12C9A.svg?style=for-the-badge)](https://paypal.me/jeffreylanters)
[![npm](https://img.shields.io/github/stars/elraccoone/unity-tweens.svg?style=for-the-badge)]()

An extremely light weight, extendable and customisable tweening engine made for script-based animations for user-interfaces and world-spaces objects optimised for all platforms.

The power and speed you expect get other tweening engines, but better, with strictly typed methods and clean and ease-to-use forward methods for all use cases.

When using any of the packages, please make sure to **Star** this repository and give credit to **Jeffrey Lanters / El Raccoone** somewhere in your app or game. **It it prohibited to distribute, sublicense, and/or sell copies of the Software!**

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

### Easing Methods

This module exposes a various number of methods, these are presented in **Extention methods** for **GameObjects** and any **Component**.

```cs
// Transforming
TweenPosition (Vector3 to, float duration);
TweenPositionX (float to, float duration);
TweenPositionY (float to, float duration);
TweenPositionZ (float to, float duration);
TweenLocalPosition (Vector3 to, float duration);
TweenLocalPositionX (float to, float duration);
TweenLocalPositionY (float to, float duration);
TweenLocalPositionZ (float to, float duration);
TweenAnchoredPosition (Vector2 to, float duration);
TweenAnchoredPositionX (float to, float duration);
TweenAnchoredPositionY (float to, float duration);
TweenRotation (Vector3 to, float duration);
TweenRotationX (float to, float duration);
TweenRotationY (float to, float duration);
TweenRotationZ (float to, float duration);
TweenLocalRotation (Vector3 to, float duration);
TweenLocalRotationX (float to, float duration);
TweenLocalRotationY (float to, float duration);
TweenLocalRotationZ (float to, float duration);
TweenLocalScale (Vector3 to, float duration);
TweenLocalScaleX (float to, float duration);
TweenLocalScaleY (float to, float duration);
TweenLocalScaleZ (float to, float duration);

// Renderers & Canvas
TweenImageFillAmount (float to, float duration);
TweenGraphicAlpha (float to, float duration);
TweenGraphicColor (Color to, float duration);
TweenSpriteRendererAlpha (float to, float duration);
TweenSpriteRendererColor (Color to, float duration);
TweenMaterialAlpha (float to, float duration);
TweenMaterialColor (Color to, float duration);
TweenTextMeshAlpha (float to, float duration);
TweenCanvasGroupAlpha (float to, float duration);

// Audio
TweenAudioSourceVolume (float to, float duration);
TweenAudioSourcePitch (float to, float duration);

// Misc
TweenValue (float to, float duration, Action<float> onUpdate);
TweenDelayedInvoke(float duration, Action onComplete);
TweenCancelAll (bool includeChildren = false, bool includeInactive = false);
```

### Options (Chainable)

When invoking a tween as show above, various options can be changed using chaining methods.

```cs
// Basics
SetFrom (T valueFrom);

// Events
SetOnComplete (Action onComplete);
SetOnCancel (Action onCancel);
SetShouldDecommissionOnDisable (bool shouldDecommissionOnDisable);

// Timing
SetPingPong ();
SetLoopCount (int loopCount);
SetInfinite ();
SetDelay (float delay, bool goToFirstFrameImmediately = false);
SetRandomTime ();
SetTime (int time);
SetPaused (bool isPaused);

// Animation
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
