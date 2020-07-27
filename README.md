<div align="center">

<img src="https://raw.githubusercontent.com/elraccoone/unity-tweens/master/.github/WIKI/logo.jpg" height="100px"></br>

# Tweens

[![npm](https://img.shields.io/badge/upm-1.6.0-232c37.svg?style=for-the-badge)]()
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

This module exposes a various number of methods, these are presented in **Extention methods** for both **GameObjects** and any type of **Component**.

#### TweenPosition

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the Position.

```cs
TweenPosition (Vector3 to, float duration);
```

#### TweenPositionX

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the PositionX.

```cs
TweenPositionX (float to, float duration);
```

#### TweenPositionY

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the PositionY.

```cs
TweenPositionY (float to, float duration);
```

#### TweenPositionZ

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the PositionZ.

```cs
TweenPositionZ (float to, float duration);
```

#### TweenLocalPosition

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalPosition.

```cs
TweenLocalPosition (Vector3 to, float duration);
```

#### TweenLocalPositionX

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalPositionX.

```cs
TweenLocalPositionX (float to, float duration);
```

#### TweenLocalPositionY

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalPositionY.

```cs
TweenLocalPositionY (float to, float duration);
```

#### TweenLocalPositionZ

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalPositionZ.

```cs
TweenLocalPositionZ (float to, float duration);
```

#### TweenAnchoredPosition

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the AnchoredPosition.

```cs
TweenAnchoredPosition (Vector2 to, float duration);
```

#### TweenAnchoredPositionX

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the AnchoredPositionX.

```cs
TweenAnchoredPositionX (float to, float duration);
```

#### TweenAnchoredPositionY

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the AnchoredPositionY.

```cs
TweenAnchoredPositionY (float to, float duration);
```

#### TweenRotation

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the Rotation.

```cs
TweenRotation (Vector3 to, float duration);
```

#### TweenRotationX

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the RotationX.

```cs
TweenRotationX (float to, float duration);
```

#### TweenRotationY

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the RotationY.

```cs
TweenRotationY (float to, float duration);
```

#### TweenRotationZ

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the RotationZ.

```cs
TweenRotationZ (float to, float duration);
```

#### TweenLocalRotation

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalRotation.

```cs
TweenLocalRotation (Vector3 to, float duration);
```

#### TweenLocalRotationX

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalRotationX.

```cs
TweenLocalRotationX (float to, float duration);
```

#### TweenLocalRotationY

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalRotationY.

```cs
TweenLocalRotationY (float to, float duration);
```

#### TweenLocalRotationZ

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalRotationZ.

```cs
TweenLocalRotationZ (float to, float duration);
```

#### TweenLocalScale

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalScale.

```cs
TweenLocalScale (Vector3 to, float duration);
```

#### TweenLocalScaleX

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalScaleX.

```cs
TweenLocalScaleX (float to, float duration);
```

#### TweenLocalScaleY

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalScaleY.

```cs
TweenLocalScaleY (float to, float duration);
```

#### TweenLocalScaleZ

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the LocalScaleZ.

```cs
TweenLocalScaleZ (float to, float duration);
```

#### TweenImageFillAmount

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the ImageFillAmount.

```cs
TweenImageFillAmount (float to, float duration);
```

#### TweenGraphicAlpha

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the GraphicAlpha.

```cs
TweenGraphicAlpha (float to, float duration);
```

#### TweenGraphicColor

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the GraphicColor.

```cs
TweenGraphicColor (Color to, float duration);
```

#### TweenSpriteRendererAlpha

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the SpriteRendererAlpha.

```cs
TweenSpriteRendererAlpha (float to, float duration);
```

#### TweenSpriteRendererColor

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the SpriteRendererColor.

```cs
TweenSpriteRendererColor (Color to, float duration);
```

#### TweenMaterialAlpha

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the MaterialAlpha.

```cs
TweenMaterialAlpha (float to, float duration);
```

#### TweenMaterialColor

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the MaterialColor.

```cs
TweenMaterialColor (Color to, float duration);
```

#### TweenTextMeshAlpha

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the TextMeshAlpha.

```cs
TweenTextMeshAlpha (float to, float duration);
```

#### TweenCanvasGroupAlpha

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the CanvasGroupAlpha.

```cs
TweenCanvasGroupAlpha (float to, float duration);
```

#### TweenAudioSourceVolume

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the AudioSourceVolume.

```cs
TweenAudioSourceVolume (float to, float duration);
```

#### TweenAudioSourcePitch

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the AudioSourcePitch.

```cs
TweenAudioSourcePitch (float to, float duration);
```

#### TweenValueFloat

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the ValueFloat.

```cs
TweenValueFloat (float to, float duration, Action<float> onUpdate);
```

#### TweenValueColor

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the ValueColor.

```cs
TweenValueColor (Color to, float duration, Action<Color> onUpdate);
```

#### TweenDelayedInvoke

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the DelayedInvoke.

```cs
TweenDelayedInvoke(float duration, Action onComplete);
```

#### TweenCancelAll

> Extention method for `GameObject` and `Component`.

Creates a Tween animating the CancelAll.

```cs
TweenCancelAll (bool includeChildren = false, bool includeInactive = false);
```

### Options

When invoking a Tween as show above, various options can be changed using the follwing **chainable methods**.

> When storing a tween in a variable, all these options can be changed afterwards as well.

```cs
// Basics
SetFrom (T valueFrom);

// Events
SetOnComplete (Action onComplete);
SetOnCancel (Action onCancel);

// Timing
SetPingPong ();
SetLoopCount (int loopCount);
SetInfinite ();
SetDelay (float delay, bool goToFirstFrameImmediately = false);
SetTime (int time);
SetRandomTime ();
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
