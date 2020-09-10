<div align="center">

<img src="https://raw.githubusercontent.com/elraccoone/unity-tweens/master/.github/WIKI/logo.jpg" height="100px"></br>

# Tweens

[![npm](https://img.shields.io/badge/upm-1.6.0-232c37.svg?style=for-the-badge)]()
[![license](https://img.shields.io/badge/license-Custom-%23ecc531.svg?style=for-the-badge)](./LICENSE.md)
[![npm](https://img.shields.io/badge/sponsor-donate-E12C9A.svg?style=for-the-badge)](https://paypal.me/jeffreylanters)
[![npm](https://img.shields.io/github/stars/elraccoone/unity-tweens.svg?style=for-the-badge)]()

An extremely light weight, extendable and customisable tweening engine made for script-based animations for user-interfaces and world-spaces objects optimised for all platforms.

[![npm](https://img.shields.io/badge/sponsor_the_project-donate-E12C9A.svg?style=for-the-badge)](https://paypal.me/jeffreylanters)

Hi! My name is Jeffrey Lanters, thanks for checking out my modules! I've been a Unity developer for years when in 2020 I decided to start sharing my modules by open-sourcing them. So feel free to look around. If you're using this module for production, please consider donating to support the project. When using any of the packages, please make sure to **Star** this repository and give credit to **Jeffrey Lanters** somewhere in your app or game. Also keep in mind **it it prohibited to sublicense and/or sell copies of the Software in stores such as the Unity Asset Store!** Thanks for your time.

**&Lt;**
[**Installation**](#installation) &middot;
[**Documentation**](#documentation) &middot;
[**License**](./LICENSE.md) &middot;
[**Sponsor**](https://paypal.me/jeffreylanters)
**&Gt;**

**Made with &hearts; by Jeffrey Lanters**

</div>

# Installation

Install using the Unity Package Manager by adding the following line to your `manifest.json` file located within your project's Packages directory.

```json
"nl.elraccoone.tweens": "git+https://github.com/elraccoone/unity-tweens"
```

# Made with

These are some of projects which are made using Tweens! If you'd like a add your project to this list, feel free to create an issue or open a pull-request with the modified readme.

[<img src="https://is5-ssl.mzstatic.com/image/thumb/Purple124/v4/5e/6a/8a/5e6a8ad5-ed2c-70fa-cb88-d6ad4b795e72/AppIcon-0-0-1x_U007emarketing-0-0-0-7-0-0-sRGB-0-0-0-GLES2_U002c0-512MB-85-220-0-0.png/460x0w.png" height="50px">](https://whoomb.com)
[<img src="https://is1-ssl.mzstatic.com/image/thumb/Purple124/v4/3f/bc/a1/3fbca1c6-7062-08cf-cd16-9ff21efaaf14/AppIcon-0-0-1x_U007emarketing-0-0-0-7-0-0-sRGB-0-0-0-GLES2_U002c0-512MB-85-220-0-0.png/460x0w.png" height="50px">](https://asgaard-saga.nl)
[<img src="https://is1-ssl.mzstatic.com/image/thumb/Purple118/v4/34/81/20/34812071-b20a-1547-341d-0b912c9ab486/AppIcon-1x_U007emarketing-0-85-220-0-8.png/460x0w.png" height="50px">](https://apps.apple.com/nl/app/kepler/id1325611598)
[<img src="https://is3-ssl.mzstatic.com/image/thumb/Purple123/v4/e4/37/85/e437858e-6e52-aeb4-c28c-c163ff89921a/AppIcon-0-0-1x_U007emarketing-0-0-0-5-0-0-sRGB-0-0-0-GLES2_U002c0-512MB-85-220-0-0.png/460x0w.png" height="50px">](https://apps.apple.com/nl/app/last-species/id1498516635)
[<img src="https://is1-ssl.mzstatic.com/image/thumb/Purple3/v4/94/a9/0f/94a90f35-42fe-684d-99cc-6b485ccd1f62/mzl.jxhhtqpi.png/460x0w.png" height="50px">](https://apps.apple.com/nl/app/haal-je-theorie-3d/id902989145)
[<img src="https://is4-ssl.mzstatic.com/image/thumb/Purple128/v4/a2/33/5d/a2335d18-6c84-0477-8ff7-0dcdc2a02501/AppIcon-1x_U007emarketing-85-220-0-5.png/460x0w.png" height="50px">](https://apps.apple.com/nl/app/skeleton/id1342556124)
[<img src="https://is4-ssl.mzstatic.com/image/thumb/Purple49/v4/68/1c/01/681c015c-2489-9964-6dcc-51090b0d58c9/pr_source.png/460x0w.png" height="50px">](https://apps.apple.com/nl/app/woordenschatkist/id1049266288)

# Documentation

This module is benchmarked against LeanTween and ITween and beats both in Unity 2020.1 with running 1000 complex tweens simulataniously. The power and speed you expect get other tweening engines, with strictly typed, clean and ease-to-use chainable methods for all use cases.

## Examples

These are some of the endless possibilities using Tweens.

```cs
private void Start () {
  myGameObject.TweenLocalRotationX (10, 1).SetFrom (-10).SetDelay (1).SetEaseQuadIn ();
  myGameObject.TweenGraphicColor (Color.red, 10).SetPingPong ().SetLoop (10).SetEaseBackInOut ();
  myGameObject.TweenValueFloat (0, 2,  (value => { })).SetFrom (100).SetEaseSineOut ();
  myGameObject.TweenCancelAll ();
}
```

## Tweening Methods

#### TweenPosition `version 1.0.0`

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

Instantiates a Tween animating the fillAmount of an image.

```cs
<GameObject, Component>.TweenImageFillAmount (float to, float duration);
```

#### TweenGraphicAlpha `version 1.0.4`

Instantiates a Tween animating the alpha of a graphic.

```cs
<GameObject, Component>.TweenGraphicAlpha (float to, float duration);
```

#### TweenGraphicColor `version 1.0.4`

Instantiates a Tween animating the color of a graphic.

```cs
<GameObject, Component>.TweenGraphicColor (Color to, float duration);
```

#### TweenSpriteRendererAlpha `version 1.0.4`

Instantiates a Tween animating the alpha of a SpriteRenderer.

```cs
<GameObject, Component>.TweenSpriteRendererAlpha (float to, float duration);
```

#### TweenSpriteRendererColor `version 1.0.5`

Instantiates a Tween animating the color of a SpriteRenderer.

```cs
<GameObject, Component>.TweenSpriteRendererColor (Color to, float duration);
```

#### TweenMaterialAlpha `version 1.0.9`

Instantiates a Tween animating the alpha of a Material.

```cs
<GameObject, Component>.TweenMaterialAlpha (float to, float duration);
```

#### TweenMaterialColor `version 1.0.9`

Instantiates a Tween animating the color of a Material.

```cs
<GameObject, Component>.TweenMaterialColor (Color to, float duration);
```

#### TweenTextMeshAlpha `version 1.0.8`

Instantiates a Tween animating the alpha of a TextMesh.

```cs
<GameObject, Component>.TweenTextMeshAlpha (float to, float duration);
```

#### TweenCanvasGroupAlpha `version 1.0.10`

Instantiates a Tween animating the alpha of a CanvasGroup.

```cs
<GameObject, Component>.TweenCanvasGroupAlpha (float to, float duration);
```

#### TweenAudioSourceVolume `version 1.0.11`

Instantiates a Tween easing the volume of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourceVolume (float to, float duration);
```

#### TweenAudioSourcePitch `version 1.0.11`

Instantiates a Tween easing the pitch of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourcePitch (float to, float duration);
```

#### TweenValueFloat `version 1.0.3`

Instantiates a Tween animating the a float value.

```cs
<GameObject, Component>.TweenValueFloat (float to, float duration, Action<float> onUpdate);
```

#### TweenValueColor `version 1.2.0`

Instantiates a Tween animating the a color value.

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

## Chainable Options

#### Cancel `version 1.0.0`

Cancel the tween.

```cs
<Tween>.Cancel ();
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

#### SetPingPong `version 1.6.0`

Enabled ping pong playback, this will bounce the animation back and forth. The tween has play forward and backwards to count as one cycle. Use either SetLoopCount or SetInifinite to set the number of times the animation should ping pong.

```cs
<Tween>.SetPingPong ();
```

#### SetLoopCount `version 1.2.0`

Sets the number of times the animation should loop.

```cs
<Tween>.SetLoopCount (int loopCount);
```

#### SetInfinite `version 1.5.0`

Sets this tween to infinite, the loopcount will be ignored.

```cs
<Tween>.SetInfinite ();
```

#### SetDelay `version 1.3.0`

Sets the delay of this tween. The tween will not play anything until the requested delay time is reached. You can change this behaviour by enabeling 'goToFirstFrameImmediately' to set the animation to the first frame immediately.

```cs
<Tween>.SetDelay (float delay, bool goToFirstFrameImmediately = false);
```

#### SetTime `version 1.1.0`

Sets the time of the tween.

```cs
<Tween>.SetTime (int time);
```

#### SetRandomTime `version 1.3.0`

Sets the time of the tween to a random value.

```cs
<Tween>.SetRandomTime ();
```

#### SetPaused `version 1.4.0`

Sets wheter the playback and delay should be paused.

```cs
<Tween>.SetPaused (bool isPaused);
```

#### SetOvershooting `version 1.5.0`

Sets the overshooting of Eases that exceed their boundaries such as elastic and back.

```cs
<Tween>.SetOvershooting (float overshooting);
```

#### SetEase `version 1.5.0`

Sets the ease for this tween.

```cs
<Tween>.SetEase (Ease ease);
```

#### SetEaseLinear `version 1.0.0`

Sets the ease for this tween to Linear.

```cs
<Tween>.SetEaseLinear ();
```

#### SetEaseSineIn `version 1.0.0`

Sets the ease for this tween to SineIn.

```cs
<Tween>.SetEaseSineIn ();
```

#### SetEaseSineOut `version 1.0.0`

Sets the ease for this tween to SineOut.

```cs
<Tween>.SetEaseSineOut ();
```

#### SetEaseSineInOut `version 1.0.0`

Sets the ease for this tween to SineInOut.

```cs
<Tween>.SetEaseSineInOut ();
```

#### SetEaseQuadIn `version 1.0.0`

Sets the ease for this tween to QuadIn.

```cs
<Tween>.SetEaseQuadIn ();
```

#### SetEaseQuadOut `version 1.0.0`

Sets the ease for this tween to QuadOut.

```cs
<Tween>.SetEaseQuadOut ();
```

#### SetEaseQuadInOut `version 1.0.0`

Sets the ease for this tween to QuadInOut.

```cs
<Tween>.SetEaseQuadInOut ();
```

#### SetEaseCubicIn `version 1.0.0`

Sets the ease for this tween to CubicIn.

```cs
<Tween>.SetEaseCubicIn ();
```

#### SetEaseCubicOut `version 1.0.0`

Sets the ease for this tween to CubicOut.

```cs
<Tween>.SetEaseCubicOut ();
```

#### SetEaseCubicInOut `version 1.0.0`

Sets the ease for this tween to CubicInOut.

```cs
<Tween>.SetEaseCubicInOut ();
```

#### SetEaseQuartIn `version 1.0.0`

Sets the ease for this tween to QuartIn.

```cs
<Tween>.SetEaseQuartIn ();
```

#### SetEaseQuartOut `version 1.0.0`

Sets the ease for this tween to QuartOut.

```cs
<Tween>.SetEaseQuartOut ();
```

#### SetEaseQuartInOut `version 1.0.0`

Sets the ease for this tween to QuartInOut.

```cs
<Tween>.SetEaseQuartInOut ();
```

#### SetEaseQuintIn `version 1.0.0`

Sets the ease for this tween to QuintIn.

```cs
<Tween>.SetEaseQuintIn ();
```

#### SetEaseQuintOut `version 1.0.0`

Sets the ease for this tween to QuintOut.

```cs
<Tween>.SetEaseQuintOut ();
```

#### SetEaseQuintInOut `version 1.0.0`

Sets the ease for this tween to QuintInOut.

```cs
<Tween>.SetEaseQuintInOut ();
```

#### SetEaseExpoIn `version 1.0.0`

Sets the ease for this tween to ExpoIn.

```cs
<Tween>.SetEaseExpoIn ();
```

#### SetEaseExpoOut `version 1.0.0`

Sets the ease for this tween to ExpoOut.

```cs
<Tween>.SetEaseExpoOut ();
```

#### SetEaseExpoInOut `version 1.0.0`

Sets the ease for this tween to ExpoInOut.

```cs
<Tween>.SetEaseExpoInOut ();
```

#### SetEaseCircIn `version 1.0.0`

Sets the ease for this tween to CircIn.

```cs
<Tween>.SetEaseCircIn ();
```

#### SetEaseCircOut `version 1.0.0`

Sets the ease for this tween to CircOut.

```cs
<Tween>.SetEaseCircOut ();
```

#### SetEaseCircInOut `version 1.0.0`

Sets the ease for this tween to CircInOut.

```cs
<Tween>.SetEaseCircInOut ();
```

#### SetEaseBackIn `version 1.0.0`

Sets the ease for this tween to BackIn.

```cs
<Tween>.SetEaseBackIn ();
```

#### SetEaseBackOut `version 1.0.0`

Sets the ease for this tween to BackOut.

```cs
<Tween>.SetEaseBackOut ();
```

#### SetEaseBackInOut `version 1.0.0`

Sets the ease for this tween to BackInOut.

```cs
<Tween>.SetEaseBackInOut ();
```

#### SetEaseElasticIn `version 1.0.0`

Sets the ease for this tween to ElasticIn.

```cs
<Tween>.SetEaseElasticIn ();
```

#### SetEaseElasticOut `version 1.0.0`

Sets the ease for this tween to ElasticOut.

```cs
<Tween>.SetEaseElasticOut ();
```

#### SetEaseElasticInOut `version 1.0.0`

Sets the ease for this tween to ElasticInOut.

```cs
<Tween>.SetEaseElasticInOut ();
```

#### SetEaseBounceIn `version 1.0.0`

Sets the ease for this tween to BounceIn.

```cs
<Tween>.SetEaseBounceIn ();
```

#### SetEaseBounceOut `version 1.0.0`

Sets the ease for this tween to BounceOut.

```cs
<Tween>.SetEaseBounceOut ();
```

#### SetEaseBounceInOut `version 1.0.0`

Sets the ease for this tween to BounceInOut.

```cs
<Tween>.SetEaseBounceInOut ();
```
