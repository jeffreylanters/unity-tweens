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

#### TweenPosition 

###### available in version 1.0.0

Instantiates a Tween animating the Position.

```cs
<GameObject, Component>.TweenPosition (Vector3 to, float duration);
```

#### TweenPositionX `version 1.0.0`

Instantiates a Tween animating the X axis of the Position.

```cs
<GameObject, Component>.TweenPositionX (float to, float duration);
```

#### TweenPositionY `version 1.0.0`

Instantiates a Tween animating the Y axis of the Position.

```cs
<GameObject, Component>.TweenPositionY (float to, float duration);
```

#### TweenPositionZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the Position.

```cs
<GameObject, Component>.TweenPositionZ (float to, float duration);
```

#### TweenLocalPosition `version 1.0.0`

Instantiates a Tween animating the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPosition (Vector3 to, float duration);
```

#### TweenLocalPositionX `version 1.0.0`

Instantiates a Tween animating the X axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionX (float to, float duration);
```

#### TweenLocalPositionY `version 1.0.0`

Instantiates a Tween animating the Y axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionY (float to, float duration);
```

#### TweenLocalPositionZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionZ (float to, float duration);
```

#### TweenAnchoredPosition `version 1.0.2`

Instantiates a Tween animating the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPosition (Vector2 to, float duration);
```

#### TweenAnchoredPositionX `version 1.0.2`

Instantiates a Tween animating the X axis of the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPositionX (float to, float duration);
```

#### TweenAnchoredPositionY `version 1.0.2`

Instantiates a Tween animating the Y axis of the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPositionY (float to, float duration);
```

#### TweenRotation `version 1.0.0`

Instantiates a Tween animating the Rotation.

```cs
<GameObject, Component>.TweenRotation (Vector3 to, float duration);
```

#### TweenRotationX `version 1.0.0`

Instantiates a Tween animating the X axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationX (float to, float duration);
```

#### TweenRotationY `version 1.0.0`

Instantiates a Tween animating the Y axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationY (float to, float duration);
```

#### TweenRotationZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationZ (float to, float duration);
```

#### TweenLocalRotation `version 1.0.0`

Instantiates a Tween animating the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotation (Vector3 to, float duration);
```

#### TweenLocalRotationX `version 1.0.0`

Instantiates a Tween animating the X axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationX (float to, float duration);
```

#### TweenLocalRotationY `version 1.0.0`

Instantiates a Tween animating the Y axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationY (float to, float duration);
```

#### TweenLocalRotationZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationZ (float to, float duration);
```

#### TweenLocalScale `version 1.0.0`

Instantiates a Tween animating the LocalScale.

```cs
<GameObject, Component>.TweenLocalScale (Vector3 to, float duration);
```

#### TweenLocalScaleX `version 1.0.0`

Instantiates a Tween animating the X axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleX (float to, float duration);
```

#### TweenLocalScaleY `version 1.0.0`

Instantiates a Tween animating the Y axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleY (float to, float duration);
```

#### TweenLocalScaleZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleZ (float to, float duration);
```

#### TweenImageFillAmount `version 1.0.3`

Instantiates a Tween animating the ImageFillAmount.

```cs
<GameObject, Component>.TweenImageFillAmount (float to, float duration);
```

#### TweenGraphicAlpha `version 1.0.4`

Instantiates a Tween animating the GraphicAlpha.

```cs
<GameObject, Component>.TweenGraphicAlpha (float to, float duration);
```

#### TweenGraphicColor `version 1.0.4`

Instantiates a Tween animating the GraphicColor.

```cs
<GameObject, Component>.TweenGraphicColor (Color to, float duration);
```

#### TweenSpriteRendererAlpha `version 1.0.4`

Instantiates a Tween animating the SpriteRendererAlpha.

```cs
<GameObject, Component>.TweenSpriteRendererAlpha (float to, float duration);
```

#### TweenSpriteRendererColor `version 1.0.5`

Instantiates a Tween animating the SpriteRendererColor.

```cs
<GameObject, Component>.TweenSpriteRendererColor (Color to, float duration);
```

#### TweenMaterialAlpha `version 1.0.9`

Instantiates a Tween animating the MaterialAlpha.

```cs
<GameObject, Component>.TweenMaterialAlpha (float to, float duration);
```

#### TweenMaterialColor `version 1.0.9`

Instantiates a Tween animating the MaterialColor.

```cs
<GameObject, Component>.TweenMaterialColor (Color to, float duration);
```

#### TweenTextMeshAlpha `version 1.0.8`

Instantiates a Tween animating the TextMeshAlpha.

```cs
<GameObject, Component>.TweenTextMeshAlpha (float to, float duration);
```

#### TweenCanvasGroupAlpha `version 1.0.10`

Instantiates a Tween animating the CanvasGroupAlpha.

```cs
<GameObject, Component>.TweenCanvasGroupAlpha (float to, float duration);
```

#### TweenAudioSourceVolume `version 1.0.11`

Instantiates a Tween animating the AudioSourceVolume.

```cs
<GameObject, Component>.TweenAudioSourceVolume (float to, float duration);
```

#### TweenAudioSourcePitch `version 1.0.11`

Instantiates a Tween animating the AudioSourcePitch.

```cs
<GameObject, Component>.TweenAudioSourcePitch (float to, float duration);
```

#### TweenValueFloat `version 1.0.3`

Instantiates a Tween animating the ValueFloat.

```cs
<GameObject, Component>.TweenValueFloat (float to, float duration, Action<float> onUpdate);
```

#### TweenValueColor `version 1.2.0`

Instantiates a Tween animating the ValueColor.

```cs
<GameObject, Component>.TweenValueColor (Color to, float duration, Action<Color> onUpdate);
```

#### TweenDelayedInvoke `version 1.0.0`

Instantiates a Tween which invokes a lambra method.

```cs
<GameObject, Component>.TweenDelayedInvoke(float duration, Action onComplete);
```

#### TweenCancelAll `version 1.0.0`

Cancels all the running tweens.

```cs
<GameObject, Component>.TweenCancelAll (bool includeChildren = false, bool includeInactive = false);
```

#### SetFrom `version 1.0.0`

Sets the From value of a tween, when not set the current value will be used.

```cs
<Tween>.SetFrom (T valueFrom);
```

#### SetOnComplete `version 1.1.0`

Sets the event which will be invoked when the tween completes playing. This will
not be invoked when the tween is canceled.

```cs
<Tween>.SetOnComplete (Action onComplete);
```

#### SetOnCancel `version 1.3.0`

Sets the event which will be invoked when the tween is canceled.

```cs
<Tween>.SetOnCancel (Action onCancel);
```

<br/><br/><br/><br/>

# ------------

```cs
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
