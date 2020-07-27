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

<br/>

## Installation

Install using the Unity Package Manager. add the following line to your `manifest.json` file located within your project's packages directory.

```json
"nl.elraccoone.tweens": "git+https://github.com/elraccoone/unity-tweens"
```

<br/>

## Documentation

<br/>

### Tweening Methods

<br/>

#### TweenPosition `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Position.

```cs
TweenPosition (Vector3 to, float duration);
```

<br/>

#### TweenPositionX `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the X axis of the Position.

```cs
TweenPositionX (float to, float duration);
```

<br/>

#### TweenPositionY `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Y axis of the Position.

```cs
TweenPositionY (float to, float duration);
```

<br/>

#### TweenPositionZ `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Z axis of the Position.

```cs
TweenPositionZ (float to, float duration);
```

<br/>

#### TweenLocalPosition `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the LocalPosition.

```cs
TweenLocalPosition (Vector3 to, float duration);
```

<br/>

#### TweenLocalPositionX `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the X axis of the LocalPosition.

```cs
TweenLocalPositionX (float to, float duration);
```

<br/>

#### TweenLocalPositionY `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Y axis of the LocalPosition.

```cs
TweenLocalPositionY (float to, float duration);
```

<br/>

#### TweenLocalPositionZ `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Z axis of the LocalPosition.

```cs
TweenLocalPositionZ (float to, float duration);
```

<br/>

#### TweenAnchoredPosition `from 1.0.2`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the AnchoredPosition.

```cs
TweenAnchoredPosition (Vector2 to, float duration);
```

<br/>

#### TweenAnchoredPositionX `from 1.0.2`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the X axis of the AnchoredPosition.

```cs
TweenAnchoredPositionX (float to, float duration);
```

<br/>

#### TweenAnchoredPositionY `from 1.0.2`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Y axis of the AnchoredPosition.

```cs
TweenAnchoredPositionY (float to, float duration);
```

<br/>

#### TweenRotation `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Rotation.

```cs
TweenRotation (Vector3 to, float duration);
```

<br/>

#### TweenRotationX `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the X axis of the Rotation.

```cs
TweenRotationX (float to, float duration);
```

<br/>

#### TweenRotationY `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Y axis of the Rotation.

```cs
TweenRotationY (float to, float duration);
```

<br/>

#### TweenRotationZ `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Z axis of the Rotation.

```cs
TweenRotationZ (float to, float duration);
```

<br/>

#### TweenLocalRotation `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the LocalRotation.

```cs
TweenLocalRotation (Vector3 to, float duration);
```

<br/>

#### TweenLocalRotationX `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the X axis of the LocalRotation.

```cs
TweenLocalRotationX (float to, float duration);
```

<br/>

#### TweenLocalRotationY `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Y axis of the LocalRotation.

```cs
TweenLocalRotationY (float to, float duration);
```

<br/>

#### TweenLocalRotationZ `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Z axis of the LocalRotation.

```cs
TweenLocalRotationZ (float to, float duration);
```

<br/>

#### TweenLocalScale `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the LocalScale.

```cs
TweenLocalScale (Vector3 to, float duration);
```

<br/>

#### TweenLocalScaleX `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the X axis of the LocalScale.

```cs
TweenLocalScaleX (float to, float duration);
```

<br/>

#### TweenLocalScaleY `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Y axis of the LocalScale.

```cs
TweenLocalScaleY (float to, float duration);
```

<br/>

#### TweenLocalScaleZ `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the Z axis of the LocalScale.

```cs
TweenLocalScaleZ (float to, float duration);
```

<br/>

#### TweenImageFillAmount `from 1.0.3`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the ImageFillAmount.

```cs
TweenImageFillAmount (float to, float duration);
```

<br/>

#### TweenGraphicAlpha `from 1.0.4`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the GraphicAlpha.

```cs
TweenGraphicAlpha (float to, float duration);
```

<br/>

#### TweenGraphicColor `from 1.0.4`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the GraphicColor.

```cs
TweenGraphicColor (Color to, float duration);
```

<br/>

#### TweenSpriteRendererAlpha `from 1.0.4`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the SpriteRendererAlpha.

```cs
TweenSpriteRendererAlpha (float to, float duration);
```

<br/>

#### TweenSpriteRendererColor `from 1.0.5`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the SpriteRendererColor.

```cs
TweenSpriteRendererColor (Color to, float duration);
```

<br/>

#### TweenMaterialAlpha `from 1.0.9`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the MaterialAlpha.

```cs
TweenMaterialAlpha (float to, float duration);
```

<br/>

#### TweenMaterialColor `from 1.0.9`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the MaterialColor.

```cs
TweenMaterialColor (Color to, float duration);
```

<br/>

#### TweenTextMeshAlpha `from 1.0.8`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the TextMeshAlpha.

```cs
TweenTextMeshAlpha (float to, float duration);
```

<br/>

#### TweenCanvasGroupAlpha `from 1.0.10`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the CanvasGroupAlpha.

```cs
TweenCanvasGroupAlpha (float to, float duration);
```

<br/>

#### TweenAudioSourceVolume `from 1.0.11`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the AudioSourceVolume.

```cs
TweenAudioSourceVolume (float to, float duration);
```

<br/>

#### TweenAudioSourcePitch `from 1.0.11`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the AudioSourcePitch.

```cs
TweenAudioSourcePitch (float to, float duration);
```

<br/>

#### TweenValueFloat `from 1.0.3`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the ValueFloat.

```cs
TweenValueFloat (float to, float duration, Action<float> onUpdate);
```

<br/>

#### TweenValueColor `from 1.2.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween animating the ValueColor.

```cs
TweenValueColor (Color to, float duration, Action<Color> onUpdate);
```

<br/>

#### TweenDelayedInvoke `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Creates a Tween which invokes a lambra method.

```cs
TweenDelayedInvoke(float duration, Action onComplete);
```

<br/>

#### TweenCancelAll `from 1.0.0`

> Extension method for `GameObject` and `Component`.

Cancels all the running tweens.

```cs
TweenCancelAll (bool includeChildren = false, bool includeInactive = false);
```

<br/>

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
