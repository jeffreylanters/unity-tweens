<div align="center">

<img src="https://raw.githubusercontent.com/elraccoone/unity-tweens/master/.github/WIKI/logo-transparent.png" height="100px">

</br>

# Tweens

[![openupm](https://img.shields.io/npm/v/nl.elraccoone.tweens?label=UPM&registry_uri=https://package.openupm.com&style=for-the-badge&color=232c37)](https://openupm.com/packages/nl.elraccoone.tweens/)
[![](https://img.shields.io/github/stars/elraccoone/unity-tweens.svg?style=for-the-badge)]()
[![](https://img.shields.io/badge/build-passing-brightgreen.svg?style=for-the-badge)]()

An extremely light weight, extendable and customisable tweening engine made for script-based animations for user-interfaces and world-spaces objects optimised for all platforms.

**&Lt;**
[**Installation**](#installation) &middot;
[**Documentation**](#documentation) &middot;
[**License**](./LICENSE.md)
**&Gt;**

</br></br>

[![npm](https://img.shields.io/badge/sponsor_the_project-donate-E12C9A.svg?style=for-the-badge)](https://paypal.me/jeffreylanters)

Hi! My name is Jeffrey Lanters, thanks for checking out my modules! I've been a Unity developer for years when in 2020 I decided to start sharing my modules by open-sourcing them. So feel free to look around. If you're using this module for production, please consider donating to support the project. When using any of the packages, please make sure to **Star** this repository and give credit to **Jeffrey Lanters** somewhere in your app or game. Also keep in mind **it it prohibited to sublicense and/or sell copies of the Software in stores such as the Unity Asset Store!** Thanks for your time.

**&Lt;**
**Made with &hearts; by Jeffrey Lanters**
**&Gt;**

</br>

</div>

# Installation

### Using the Unity Package Manager

Install the latest stable release using the Unity Package Manager by adding the following line to your `manifest.json` file located within your project's Packages directory, or by adding the Git URL to the Package Manager Window inside of Unity.

```json
"nl.elraccoone.tweens": "git+https://github.com/elraccoone/unity-tweens"
```

### Using OpenUPM

The module is availble on the OpenUPM package registry, you can install the latest stable release using the OpenUPM Package manager's Command Line Tool using the following command.

```sh
openupm add nl.elraccoone.tweens
```

# Documentation

This module is benchmarked against LeanTween and ITween and beats both in Unity 2020.1 with running 1000 complex tweens simulataniously. The power and speed you expect get other tweening engines, with strictly typed, clean and ease-to-use chainable methods for all use cases.

The documentation is seperated into two parts; the [Tweening Methods](#tweening-methods), [Chainable Options](#chainable-options) and [Methods](#methods).

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
<GameObject, Component>.TweenPosition (Vector3 to, float duration) : Tween;
```

#### TweenPositionX `version 1.0.0`

Instantiates a Tween animating the X axis of the Position.

```cs
<GameObject, Component>.TweenPositionX (float to, float duration) : Tween;
```

#### TweenPositionY `version 1.0.0`

Instantiates a Tween animating the Y axis of the Position.

```cs
<GameObject, Component>.TweenPositionY (float to, float duration) : Tween;
```

#### TweenPositionZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the Position.

```cs
<GameObject, Component>.TweenPositionZ (float to, float duration) : Tween;
```

#### TweenLocalPosition `version 1.0.0`

Instantiates a Tween animating the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPosition (Vector3 to, float duration) : Tween;
```

#### TweenLocalPositionX `version 1.0.0`

Instantiates a Tween animating the X axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionX (float to, float duration) : Tween;
```

#### TweenLocalPositionY `version 1.0.0`

Instantiates a Tween animating the Y axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionY (float to, float duration) : Tween;
```

#### TweenLocalPositionZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionZ (float to, float duration) : Tween;
```

#### TweenAnchoredPosition `version 1.0.2`

Instantiates a Tween animating the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPosition (Vector2 to, float duration) : Tween;
```

#### TweenAnchoredPositionX `version 1.0.2`

Instantiates a Tween animating the X axis of the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPositionX (float to, float duration) : Tween;
```

#### TweenAnchoredPositionY `version 1.0.2`

Instantiates a Tween animating the Y axis of the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPositionY (float to, float duration) : Tween;
```

#### TweenRotation `version 1.0.0`

Instantiates a Tween animating the Rotation.

```cs
<GameObject, Component>.TweenRotation (Vector3 to, float duration) : Tween;
```

#### TweenRotationX `version 1.0.0`

Instantiates a Tween animating the X axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationX (float to, float duration) : Tween;
```

#### TweenRotationY `version 1.0.0`

Instantiates a Tween animating the Y axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationY (float to, float duration) : Tween;
```

#### TweenRotationZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationZ (float to, float duration) : Tween;
```

#### TweenLocalRotation `version 1.0.0`

Instantiates a Tween animating the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotation (Vector3 to, float duration) : Tween;
```

#### TweenLocalRotationX `version 1.0.0`

Instantiates a Tween animating the X axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationX (float to, float duration) : Tween;
```

#### TweenLocalRotationY `version 1.0.0`

Instantiates a Tween animating the Y axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationY (float to, float duration) : Tween;
```

#### TweenLocalRotationZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationZ (float to, float duration) : Tween;
```

#### TweenLocalScale `version 1.0.0`

Instantiates a Tween animating the LocalScale.

```cs
<GameObject, Component>.TweenLocalScale (Vector3 to, float duration) : Tween;
```

#### TweenLocalScaleX `version 1.0.0`

Instantiates a Tween animating the X axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleX (float to, float duration) : Tween;
```

#### TweenLocalScaleY `version 1.0.0`

Instantiates a Tween animating the Y axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleY (float to, float duration) : Tween;
```

#### TweenLocalScaleZ `version 1.0.0`

Instantiates a Tween animating the Z axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleZ (float to, float duration) : Tween;
```

#### TweenImageFillAmount `version 1.0.3`

Instantiates a Tween animating the fillAmount of an image.

```cs
<GameObject, Component>.TweenImageFillAmount (float to, float duration) : Tween;
```

#### TweenGraphicAlpha `version 1.0.4`

Instantiates a Tween animating the alpha of a graphic.

```cs
<GameObject, Component>.TweenGraphicAlpha (float to, float duration) : Tween;
```

#### TweenGraphicColor `version 1.0.4`

Instantiates a Tween animating the color of a graphic.

```cs
<GameObject, Component>.TweenGraphicColor (Color to, float duration) : Tween;
```

#### TweenSpriteRendererAlpha `version 1.0.4`

Instantiates a Tween animating the alpha of a SpriteRenderer.

```cs
<GameObject, Component>.TweenSpriteRendererAlpha (float to, float duration) : Tween;
```

#### TweenSpriteRendererColor `version 1.0.5`

Instantiates a Tween animating the color of a SpriteRenderer.

```cs
<GameObject, Component>.TweenSpriteRendererColor (Color to, float duration) : Tween;
```

#### TweenMaterialAlpha `version 1.0.9`

Instantiates a Tween animating the alpha of a Material.

```cs
<GameObject, Component>.TweenMaterialAlpha (float to, float duration) : Tween;
```

#### TweenMaterialColor `version 1.0.9`

Instantiates a Tween animating the color of a Material.

```cs
<GameObject, Component>.TweenMaterialColor (Color to, float duration) : Tween;
```

#### TweenTextMeshAlpha `version 1.0.8`

Instantiates a Tween animating the alpha of a TextMesh.

```cs
<GameObject, Component>.TweenTextMeshAlpha (float to, float duration) : Tween;
```

#### TweenCanvasGroupAlpha `version 1.0.10`

Instantiates a Tween animating the alpha of a CanvasGroup.

```cs
<GameObject, Component>.TweenCanvasGroupAlpha (float to, float duration) : Tween;
```

#### TweenAudioSourceVolume `version 1.0.11`

Instantiates a Tween easing the volume of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourceVolume (float to, float duration) : Tween;
```

#### TweenAudioSourcePitch `version 1.0.11`

Instantiates a Tween easing the pitch of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourcePitch (float to, float duration) : Tween;
```

#### TweenCameraFieldOfView `version 1.6.4`

Instantiates a Tween easing the field of view of a Camera.

```cs
<GameObject, Component>.TweenCameraFieldOfView (float to, float duration) : Tween;
```

#### TweenCameraOrthographicSize `version 1.6.4`

Instantiates a Tween easing the orthographic size of a Camera.

```cs
<GameObject, Component>.TweenCameraOrthographicSize (float to, float duration) : Tween;
```

#### TweenValueFloat `version 1.0.3`

Instantiates a Tween animating the a float value.

```cs
<GameObject, Component>.TweenValueFloat (float to, float duration, Action<float> onUpdate) : Tween;
```

#### TweenValueColor `version 1.2.0`

Instantiates a Tween animating the a color value.

```cs
<GameObject, Component>.TweenValueColor (Color to, float duration, Action<Color> onUpdate) : Tween;
```

#### TweenDelayedInvoke `version 1.0.0`

Instantiates a Tween which invokes a lambra method.

```cs
<GameObject, Component>.TweenDelayedInvoke(float duration, Action onComplete) : Tween;
```

#### TweenCancelAll `version 1.0.0`

Cancels all the running tweens.

```cs
<GameObject, Component>.TweenCancelAll (bool includeChildren = false, bool includeInactive = false) : Tween;
```

## Chainable Options

#### SetFrom `version 1.0.0`

Sets the From value of a tween, when not set the current value will be used.

```cs
<Tween>.SetFrom (T valueFrom) : Tween;
```

#### SetOnComplete `version 1.1.0`

Sets the event which will be invoked when the tween completes playing. This will
not be invoked when the tween is canceled.

```cs
<Tween>.SetOnComplete (Action onComplete) : Tween;
```

#### SetOnCancel `version 1.3.0`

Sets the event which will be invoked when the tween is canceled.

```cs
<Tween>.SetOnCancel (Action onCancel) : Tween;
```

#### SetPingPong `version 1.6.0`

Enabled ping pong playback, this will bounce the animation back and forth. The tween has play forward and backwards to count as one cycle. Use either SetLoopCount or SetInifinite to set the number of times the animation should ping pong.

```cs
<Tween>.SetPingPong () : Tween;
```

#### SetLoopCount `version 1.2.0`

Sets the number of times the animation should loop.

```cs
<Tween>.SetLoopCount (int loopCount) : Tween;
```

#### SetInfinite `version 1.5.0`

Sets this tween to infinite, the loopcount will be ignored.

```cs
<Tween>.SetInfinite () : Tween;
```

#### SetDelay `version 1.3.0`

Sets the delay of this tween. The tween will not play anything until the requested delay time is reached. You can change this behaviour by enabeling 'goToFirstFrameImmediately' to set the animation to the first frame immediately.

```cs
<Tween>.SetDelay (float delay, bool goToFirstFrameImmediately = false) : Tween;
```

#### SetTime `version 1.1.0`

Sets the time of the tween.

```cs
<Tween>.SetTime (float time) : Tween;
```

#### SetRandomTime `version 1.3.0`

Sets the time of the tween to a random value.

```cs
<Tween>.SetRandomTime () : Tween;
```

#### SetPaused `version 1.4.0`

Sets whether the playback and delay should be paused.

```cs
<Tween>.SetPaused (bool isPaused) : Tween;
```

#### SetUseUnscaledTime `version 1.6.1`

Sets whether the tween should use the unscaled delta time instead of the scaled delta time.

```cs
<Tween>.SetUseUnscaledTime (bool useUnscaledTime) : Tween;
```

#### SetOvershooting `version 1.5.0`

Sets the overshooting of Eases that exceed their boundaries such as elastic and back.

```cs
<Tween>.SetOvershooting (float overshooting) : Tween;
```

#### SetEase `version 1.5.0`

Sets the ease for this tween.

```cs
<Tween>.SetEase (Ease ease) : Tween;
```

#### SetEaseLinear `version 1.0.0`

Sets the ease for this tween to Linear.

```cs
<Tween>.SetEaseLinear () : Tween;
```

#### SetEaseSineIn `version 1.0.0`

Sets the ease for this tween to SineIn.

```cs
<Tween>.SetEaseSineIn () : Tween;
```

#### SetEaseSineOut `version 1.0.0`

Sets the ease for this tween to SineOut.

```cs
<Tween>.SetEaseSineOut () : Tween;
```

#### SetEaseSineInOut `version 1.0.0`

Sets the ease for this tween to SineInOut.

```cs
<Tween>.SetEaseSineInOut () : Tween;
```

#### SetEaseQuadIn `version 1.0.0`

Sets the ease for this tween to QuadIn.

```cs
<Tween>.SetEaseQuadIn () : Tween;
```

#### SetEaseQuadOut `version 1.0.0`

Sets the ease for this tween to QuadOut.

```cs
<Tween>.SetEaseQuadOut () : Tween;
```

#### SetEaseQuadInOut `version 1.0.0`

Sets the ease for this tween to QuadInOut.

```cs
<Tween>.SetEaseQuadInOut () : Tween;
```

#### SetEaseCubicIn `version 1.0.0`

Sets the ease for this tween to CubicIn.

```cs
<Tween>.SetEaseCubicIn () : Tween;
```

#### SetEaseCubicOut `version 1.0.0`

Sets the ease for this tween to CubicOut.

```cs
<Tween>.SetEaseCubicOut () : Tween;
```

#### SetEaseCubicInOut `version 1.0.0`

Sets the ease for this tween to CubicInOut.

```cs
<Tween>.SetEaseCubicInOut () : Tween;
```

#### SetEaseQuartIn `version 1.0.0`

Sets the ease for this tween to QuartIn.

```cs
<Tween>.SetEaseQuartIn () : Tween;
```

#### SetEaseQuartOut `version 1.0.0`

Sets the ease for this tween to QuartOut.

```cs
<Tween>.SetEaseQuartOut () : Tween;
```

#### SetEaseQuartInOut `version 1.0.0`

Sets the ease for this tween to QuartInOut.

```cs
<Tween>.SetEaseQuartInOut () : Tween;
```

#### SetEaseQuintIn `version 1.0.0`

Sets the ease for this tween to QuintIn.

```cs
<Tween>.SetEaseQuintIn () : Tween;
```

#### SetEaseQuintOut `version 1.0.0`

Sets the ease for this tween to QuintOut.

```cs
<Tween>.SetEaseQuintOut () : Tween;
```

#### SetEaseQuintInOut `version 1.0.0`

Sets the ease for this tween to QuintInOut.

```cs
<Tween>.SetEaseQuintInOut () : Tween;
```

#### SetEaseExpoIn `version 1.0.0`

Sets the ease for this tween to ExpoIn.

```cs
<Tween>.SetEaseExpoIn () : Tween;
```

#### SetEaseExpoOut `version 1.0.0`

Sets the ease for this tween to ExpoOut.

```cs
<Tween>.SetEaseExpoOut () : Tween;
```

#### SetEaseExpoInOut `version 1.0.0`

Sets the ease for this tween to ExpoInOut.

```cs
<Tween>.SetEaseExpoInOut () : Tween;
```

#### SetEaseCircIn `version 1.0.0`

Sets the ease for this tween to CircIn.

```cs
<Tween>.SetEaseCircIn () : Tween;
```

#### SetEaseCircOut `version 1.0.0`

Sets the ease for this tween to CircOut.

```cs
<Tween>.SetEaseCircOut () : Tween;
```

#### SetEaseCircInOut `version 1.0.0`

Sets the ease for this tween to CircInOut.

```cs
<Tween>.SetEaseCircInOut () : Tween;
```

#### SetEaseBackIn `version 1.0.0`

Sets the ease for this tween to BackIn.

```cs
<Tween>.SetEaseBackIn () : Tween;
```

#### SetEaseBackOut `version 1.0.0`

Sets the ease for this tween to BackOut.

```cs
<Tween>.SetEaseBackOut () : Tween;
```

#### SetEaseBackInOut `version 1.0.0`

Sets the ease for this tween to BackInOut.

```cs
<Tween>.SetEaseBackInOut () : Tween;
```

#### SetEaseElasticIn `version 1.0.0`

Sets the ease for this tween to ElasticIn.

```cs
<Tween>.SetEaseElasticIn () : Tween;
```

#### SetEaseElasticOut `version 1.0.0`

Sets the ease for this tween to ElasticOut.

```cs
<Tween>.SetEaseElasticOut () : Tween;
```

#### SetEaseElasticInOut `version 1.0.0`

Sets the ease for this tween to ElasticInOut.

```cs
<Tween>.SetEaseElasticInOut () : Tween;
```

#### SetEaseBounceIn `version 1.0.0`

Sets the ease for this tween to BounceIn.

```cs
<Tween>.SetEaseBounceIn () : Tween;
```

#### SetEaseBounceOut `version 1.0.0`

Sets the ease for this tween to BounceOut.

```cs
<Tween>.SetEaseBounceOut () : Tween;
```

#### SetEaseBounceInOut `version 1.0.0`

Sets the ease for this tween to BounceInOut.

```cs
<Tween>.SetEaseBounceInOut () : Tween;
```

## Methods

#### Cancel `version 1.0.0`

Cancel the tween.

```cs
<Tween>.Cancel () : void;
```

#### GetTotalDuration `version 1.6.2`

Gets the total duration of the tween including the loop count and ping pong settings, and the delay optionally.

```cs
<Tween>.GetTotalDuration (bool includeDelay = false) : float;
```
