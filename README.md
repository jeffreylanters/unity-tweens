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

#### TweenPosition `version 1.0.0`

Creates a Tween animating the Position.

```cs
<GameObject, Component>.TweenPosition (Vector3 to, float duration);
```

#### TweenPositionX `version 1.0.0`

Creates a Tween animating the X axis of the Position.

```cs
<GameObject, Component>.TweenPositionX (float to, float duration);
```

<br/>

#### TweenPositionY `version 1.0.0`

Creates a Tween animating the Y axis of the Position.

```cs
<GameObject, Component>.TweenPositionY (float to, float duration);
```

<br/>

#### TweenPositionZ `version 1.0.0`

Creates a Tween animating the Z axis of the Position.

```cs
<GameObject, Component>.TweenPositionZ (float to, float duration);
```

<br/>

#### TweenLocalPosition `version 1.0.0`

Creates a Tween animating the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPosition (Vector3 to, float duration);
```

<br/>

#### TweenLocalPositionX `version 1.0.0`

Creates a Tween animating the X axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionX (float to, float duration);
```

<br/>

#### TweenLocalPositionY `version 1.0.0`

Creates a Tween animating the Y axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionY (float to, float duration);
```

<br/>

#### TweenLocalPositionZ `version 1.0.0`

Creates a Tween animating the Z axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionZ (float to, float duration);
```

<br/>

#### TweenAnchoredPosition `version 1.0.2`

Creates a Tween animating the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPosition (Vector2 to, float duration);
```

<br/>

#### TweenAnchoredPositionX `version 1.0.2`

Creates a Tween animating the X axis of the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPositionX (float to, float duration);
```

<br/>

#### TweenAnchoredPositionY `version 1.0.2`

Creates a Tween animating the Y axis of the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPositionY (float to, float duration);
```

<br/>

#### TweenRotation `version 1.0.0`

Creates a Tween animating the Rotation.

```cs
<GameObject, Component>.TweenRotation (Vector3 to, float duration);
```

<br/>

#### TweenRotationX `version 1.0.0`

Creates a Tween animating the X axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationX (float to, float duration);
```

<br/>

#### TweenRotationY `version 1.0.0`

Creates a Tween animating the Y axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationY (float to, float duration);
```

<br/>

#### TweenRotationZ `version 1.0.0`

Creates a Tween animating the Z axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationZ (float to, float duration);
```

<br/>

#### TweenLocalRotation `version 1.0.0`

Creates a Tween animating the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotation (Vector3 to, float duration);
```

<br/>

#### TweenLocalRotationX `version 1.0.0`

Creates a Tween animating the X axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationX (float to, float duration);
```

<br/>

#### TweenLocalRotationY `version 1.0.0`

Creates a Tween animating the Y axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationY (float to, float duration);
```

<br/>

#### TweenLocalRotationZ `version 1.0.0`

Creates a Tween animating the Z axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationZ (float to, float duration);
```

<br/>

#### TweenLocalScale `version 1.0.0`

Creates a Tween animating the LocalScale.

```cs
<GameObject, Component>.TweenLocalScale (Vector3 to, float duration);
```

<br/>

#### TweenLocalScaleX `version 1.0.0`

Creates a Tween animating the X axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleX (float to, float duration);
```

<br/>

#### TweenLocalScaleY `version 1.0.0`

Creates a Tween animating the Y axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleY (float to, float duration);
```

<br/>

#### TweenLocalScaleZ `version 1.0.0`

Creates a Tween animating the Z axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleZ (float to, float duration);
```

<br/>

#### TweenImageFillAmount `version 1.0.3`

Creates a Tween animating the ImageFillAmount.

```cs
<GameObject, Component>.TweenImageFillAmount (float to, float duration);
```

<br/>

#### TweenGraphicAlpha `version 1.0.4`

Creates a Tween animating the GraphicAlpha.

```cs
<GameObject, Component>.TweenGraphicAlpha (float to, float duration);
```

<br/>

#### TweenGraphicColor `version 1.0.4`

Creates a Tween animating the GraphicColor.

```cs
<GameObject, Component>.TweenGraphicColor (Color to, float duration);
```

<br/>

#### TweenSpriteRendererAlpha `version 1.0.4`

Creates a Tween animating the SpriteRendererAlpha.

```cs
<GameObject, Component>.TweenSpriteRendererAlpha (float to, float duration);
```

<br/>

#### TweenSpriteRendererColor `version 1.0.5`

Creates a Tween animating the SpriteRendererColor.

```cs
<GameObject, Component>.TweenSpriteRendererColor (Color to, float duration);
```

<br/>

#### TweenMaterialAlpha `version 1.0.9`

Creates a Tween animating the MaterialAlpha.

```cs
<GameObject, Component>.TweenMaterialAlpha (float to, float duration);
```

<br/>

#### TweenMaterialColor `version 1.0.9`

Creates a Tween animating the MaterialColor.

```cs
<GameObject, Component>.TweenMaterialColor (Color to, float duration);
```

<br/>

#### TweenTextMeshAlpha `version 1.0.8`

Creates a Tween animating the TextMeshAlpha.

```cs
<GameObject, Component>.TweenTextMeshAlpha (float to, float duration);
```

<br/>

#### TweenCanvasGroupAlpha `version 1.0.10`

Creates a Tween animating the CanvasGroupAlpha.

```cs
<GameObject, Component>.TweenCanvasGroupAlpha (float to, float duration);
```

<br/>

#### TweenAudioSourceVolume `version 1.0.11`

Creates a Tween animating the AudioSourceVolume.

```cs
<GameObject, Component>.TweenAudioSourceVolume (float to, float duration);
```

<br/>

#### TweenAudioSourcePitch `version 1.0.11`

Creates a Tween animating the AudioSourcePitch.

```cs
<GameObject, Component>.TweenAudioSourcePitch (float to, float duration);
```

<br/>

#### TweenValueFloat `version 1.0.3`

Creates a Tween animating the ValueFloat.

```cs
<GameObject, Component>.TweenValueFloat (float to, float duration, Action<float> onUpdate);
```

<br/>

#### TweenValueColor `version 1.2.0`

Creates a Tween animating the ValueColor.

```cs
<GameObject, Component>.TweenValueColor (Color to, float duration, Action<Color> onUpdate);
```

<br/>

#### TweenDelayedInvoke `version 1.0.0`

Creates a Tween which invokes a lambra method.

```cs
<GameObject, Component>.TweenDelayedInvoke(float duration, Action onComplete);
```

<br/>

#### TweenCancelAll `version 1.0.0`

Cancels all the running tweens.

```cs
<GameObject, Component>.TweenCancelAll (bool includeChildren = false, bool includeInactive = false);
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
