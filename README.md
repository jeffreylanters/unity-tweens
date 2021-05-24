<div align="center">

<img src="https://raw.githubusercontent.com/jeffreylanters/unity-tweens/master/.github/WIKI/repository-readme-splash.png" width="100%">

</br>
</br>

[![openupm](https://img.shields.io/npm/v/nl.elraccoone.tweens?label=UPM&registry_uri=https://package.openupm.com&style=for-the-badge&color=232c37)](https://openupm.com/packages/nl.elraccoone.tweens/)
[![](https://img.shields.io/github/stars/jeffreylanters/unity-tweens.svg?style=for-the-badge)]()
[![](https://img.shields.io/badge/build-passing-brightgreen.svg?style=for-the-badge)]()

An extremely light weight, extendable and customisable tweening engine made for strictly typed script-based animations for user-interfaces and world-space objects optimised for all platforms.

**&Lt;**
[**Installation**](#installation) &middot;
[**Documentation**](#documentation) &middot;
[**License**](./LICENSE.md)
**&Gt;**

</br></br>

[![npm](https://img.shields.io/badge/fund_this_project-sponsor-E12C9A.svg?style=for-the-badge)](https://github.com/sponsors/jeffreylanters)

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
"nl.elraccoone.tweens": "git+https://github.com/jeffreylanters/unity-tweens"
```

### Using OpenUPM

The module is availble on the OpenUPM package registry, you can install the latest stable release using the OpenUPM Package manager's Command Line Tool using the following command.

```sh
openupm add nl.elraccoone.tweens
```

# Documentation

This module is benchmarked against LeanTween and ITween and beats both in Unity 2020.1 with running 1000 complex tweens simulataniously. The power and speed you expect get other tweening engines, with strictly typed, clean and ease-to-use chainable methods for all use cases.

- [Getting Started](#getting-started)
- [Tweening Methods](#tweening-methods)
- [Chainable Options](#chainable-options)
- [Other Methods](#other-methods)

## Getting Started

These are some of the endless possibilities using Tweens. [Tweens](#tweening-methods) can be invoked on any GameObject and Component and fetches their own required components so you don't have to. [Chainable Options](#chainable-options) can used to customize the behaviour to your needs.

```cs
using UnityEngine;
using ElRaccoone.Tweens;
public class MyGameObject : MonoBehaviour {
  private void Start () {
    gameObject.TweenLocalRotationX (10, 1).SetFrom (-10).SetDelay (1).SetEaseQuadIn ();
    gameObject.TweenGraphicColor (Color.red, 10).SetPingPong ().SetLoop (10).SetEaseBackInOut ();
    gameObject.TweenValueFloat (0, 2,  (value => { })).SetFrom (100).SetEaseSineOut ();
    gameObject.TweenCancelAll ();
  }
  private async void Chain () {
    await gameObject.TweenPosition (new Vector3 (10, 1, 15), 5).SetEaseSineInOut ().Yield ();
    await gameObject.TweenPosition (new Vector3 (25, 5, 30), 5).SetEaseSineInOut ().Yield ();
    await gameObject.TweenScaleY (100, 5).SetFrom (1).SetLoopCount (5).Yield ();
  }
}
```

## Tweening Methods

#### Tween Position

`version 1.0.0`

Instantiates a Tween animating the Position.

```cs
<GameObject, Component>.TweenPosition (Vector3 to, float duration) : Tween<Vector3>;
```

#### Tween Position X

`version 1.0.0`

Instantiates a Tween animating the X axis of the Position.

```cs
<GameObject, Component>.TweenPositionX (float to, float duration) : Tween<float>;
```

#### Tween Position Y

`version 1.0.0`

Instantiates a Tween animating the Y axis of the Position.

```cs
<GameObject, Component>.TweenPositionY (float to, float duration) : Tween<float>;
```

#### Tween Position Z

`version 1.0.0`

Instantiates a Tween animating the Z axis of the Position.

```cs
<GameObject, Component>.TweenPositionZ (float to, float duration) : Tween<float>;
```

#### Tween Local Position

`version 1.0.0`

Instantiates a Tween animating the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPosition (Vector3 to, float duration) : Tween<Vector3>;
```

#### Tween Local Position X

`version 1.0.0`

Instantiates a Tween animating the X axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionX (float to, float duration) : Tween<float>;
```

#### Tween Local Position Y

`version 1.0.0`

Instantiates a Tween animating the Y axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionY (float to, float duration) : Tween<float>;
```

#### Tween Local Position Z

`version 1.0.0`

Instantiates a Tween animating the Z axis of the LocalPosition.

```cs
<GameObject, Component>.TweenLocalPositionZ (float to, float duration) : Tween<float>;
```

#### Tween Anchored Position

`version 1.0.2`

Instantiates a Tween animating the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPosition (Vector2 to, float duration) : Tween<Vector2>;
```

#### Tween Anchored Position X

`version 1.0.2`

Instantiates a Tween animating the X axis of the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPositionX (float to, float duration) : Tween<float>;
```

#### Tween Anchored Position Y

`version 1.0.2`

Instantiates a Tween animating the Y axis of the AnchoredPosition.

```cs
<GameObject, Component>.TweenAnchoredPositionY (float to, float duration) : Tween<float>;
```

#### Tween Rotation

`version 1.0.0`

Instantiates a Tween animating the Rotation.

```cs
<GameObject, Component>.TweenRotation (Vector3 to, float duration) : Tween<Vector3>;
```

#### Tween Rotation X

`version 1.0.0`

Instantiates a Tween animating the X axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationX (float to, float duration) : Tween<float>;
```

#### Tween Rotation Y

`version 1.0.0`

Instantiates a Tween animating the Y axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationY (float to, float duration) : Tween<float>;
```

#### Tween Rotation Z

`version 1.0.0`

Instantiates a Tween animating the Z axis of the Rotation.

```cs
<GameObject, Component>.TweenRotationZ (float to, float duration) : Tween<float>;
```

#### Tween Local Rotation

`version 1.0.0`

Instantiates a Tween animating the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotation (Vector3 to, float duration) : Tween<Vector3>;
```

#### Tween Local Rotation X

`version 1.0.0`

Instantiates a Tween animating the X axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationX (float to, float duration) : Tween<float>;
```

#### Tween Local Rotation Y

`version 1.0.0`

Instantiates a Tween animating the Y axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationY (float to, float duration) : Tween<float>;
```

#### Tween Local Rotation Z

`version 1.0.0`

Instantiates a Tween animating the Z axis of the LocalRotation.

```cs
<GameObject, Component>.TweenLocalRotationZ (float to, float duration) : Tween<float>;
```

#### Tween Local Scale

`version 1.0.0`

Instantiates a Tween animating the LocalScale.

```cs
<GameObject, Component>.TweenLocalScale (Vector3 to, float duration) : Tween<Vector3>;
```

#### Tween Local Scale X

`version 1.0.0`

Instantiates a Tween animating the X axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleX (float to, float duration) : Tween<float>;
```

#### Tween Local Scale Y

`version 1.0.0`

Instantiates a Tween animating the Y axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleY (float to, float duration) : Tween<float>;
```

#### Tween Local Scale Z

`version 1.0.0`

Instantiates a Tween animating the Z axis of the LocalScale.

```cs
<GameObject, Component>.TweenLocalScaleZ (float to, float duration) : Tween<float>;
```

#### Tween Image Fill Amount

`version 1.0.3`

Instantiates a Tween animating the fillAmount of an image.

```cs
<GameObject, Component>.TweenImageFillAmount (float to, float duration) : Tween<float>;
```

#### Tween Graphic Alpha

`version 1.0.4`

Instantiates a Tween animating the alpha of a graphic.

```cs
<GameObject, Component>.TweenGraphicAlpha (float to, float duration) : Tween<float>;
```

#### Tween Graphic Color

`version 1.0.4`

Instantiates a Tween animating the color of a graphic.

```cs
<GameObject, Component>.TweenGraphicColor (Color to, float duration) : Tween<Color>;
```

#### Tween Sprite Renderer Alpha

`version 1.0.4`

Instantiates a Tween animating the alpha of a SpriteRenderer.

```cs
<GameObject, Component>.TweenSpriteRendererAlpha (float to, float duration) : Tween<float>;
```

#### Tween Sprite Renderer Color

`version 1.0.5`

Instantiates a Tween animating the color of a SpriteRenderer.

```cs
<GameObject, Component>.TweenSpriteRendererColor (Color to, float duration) : Tween<Color>;
```

#### Tween Material Alpha

`version 1.0.9`

Instantiates a Tween animating the alpha of a Material.

```cs
<GameObject, Component>.TweenMaterialAlpha (float to, float duration) : Tween<float>;
```

#### Tween Material Color

`version 1.0.9`

Instantiates a Tween animating the color of a Material.

```cs
<GameObject, Component>.TweenMaterialColor (Color to, float duration) : Tween<Color>;
```

#### Tween Text Mesh Alpha

`version 1.0.8`

Instantiates a Tween animating the alpha of a TextMesh.

```cs
<GameObject, Component>.TweenTextMeshAlpha (float to, float duration) : Tween<float>;
```

#### Tween Text Mesh Color

`version 1.7.0`

Instantiates a Tween animating the color of a TextMesh.

```cs
<GameObject, Component>.TweenTextMeshColor (Color to, float duration) : Tween<Color>;
```

#### Tween Text Mesh Pro Color (Text Mesh Pro)

`version 1.7.0`

`requires com.unity.textmeshpro`

Instantiates a Tween animating the color of a TextMeshPro.

```cs
<GameObject, Component>.TweenTextMeshProColor (Color to, float duration) : Tween<Color>;
```

#### Tween Text Mesh Pro Alpha (Text Mesh Pro)

`version 1.7.0`

`requires com.unity.textmeshpro`

Instantiates a Tween animating the alpha of a TextMeshPro.

```cs
<GameObject, Component>.TweenTextMeshProAlpha (float to, float duration) : Tween<float>;
```

#### Tween Canvas Group Alpha

`version 1.0.10`

Instantiates a Tween animating the alpha of a CanvasGroup.

```cs
<GameObject, Component>.TweenCanvasGroupAlpha (float to, float duration) : Tween<float>;
```

#### Tween Audio Source Volume

`version 1.0.11`

Instantiates a Tween easing the volume of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourceVolume (float to, float duration) : Tween<float>;
```

#### Tween Audio Source Pitch

`version 1.0.11`

Instantiates a Tween easing the pitch of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourcePitch (float to, float duration) : Tween<float>;
```

#### Tween Camera Field Of View

`version 1.6.4`

Instantiates a Tween easing the field of view of a Camera.

```cs
<GameObject, Component>.TweenCameraFieldOfView (float to, float duration) : Tween<float>;
```

#### Tween Camera Orthographic Size

`version 1.6.4`

Instantiates a Tween easing the orthographic size of a Camera.

```cs
<GameObject, Component>.TweenCameraOrthographicSize (float to, float duration) : Tween<float>;
```

#### Tween Light Color

`version 1.6.6`

Instantiates a Tween easing the color of a Light.

```cs
<GameObject, Component>.TweenLightColor (Color to, float duration) : Tween<Color>;
```

#### Tween Volume Weight (Scriptable Render Pipeline)

`version 1.6.7`

`requires com.unity.render-pipelines.core`

Instantiates a Tween animating the weight of a post-processing volume.

```cs
<GameObject, Component>.TweenVolumeWeight (float to, float duration) : Tween<float>;
```

#### Tween Value Float

`version 1.0.3`

Instantiates a Tween animating the a float value.

```cs
<GameObject, Component>.TweenValueFloat (float to, float duration, Action<float> onUpdate) : Tween<float>;
```

#### Tween Value Vector2

`version 1.6.5`

Instantiates a Tween animating the a Vector2 value.

```cs
<GameObject, Component>.TweenValueVector2 (Vector2 to, float duration, Action<Vector2> onUpdate) : Tween<Vector2>;
```

#### Tween Value Vector3

`version 1.6.5`

Instantiates a Tween animating the a Vector3 value.

```cs
<GameObject, Component>.TweenValueVector3 (Vector3 to, float duration, Action<Vector3> onUpdate) : Tween<Vector3>;
```

#### Tween Value Color

`version 1.2.0`

Instantiates a Tween animating the a color value.

```cs
<GameObject, Component>.TweenValueColor (Color to, float duration, Action<Color> onUpdate) : Tween<Color>;
```

#### Tween Delayed Invoke

`version 1.0.0`

Instantiates a Tween which invokes a lambra method.

```cs
<GameObject, Component>.TweenDelayedInvoke (float duration, Action onComplete) : Tween<float>;
```

#### Tween Cancel All

`version 1.0.0`

Cancels all the running tweens.

```cs
<GameObject, Component>.TweenCancelAll (bool includeChildren = false, bool includeInactive = false) : Tween<T>;
```

## Chainable Options

#### Set From

`version 1.0.0`

Sets the From value of a tween, when not set the current value will be used.

```cs
<Tween>.SetFrom (T valueFrom) : Tween<T>;
```

#### Set On Complete

`version 1.1.0`

Sets the event which will be invoked when the tween completes playing. This will
not be invoked when the tween is canceled.

```cs
<Tween>.SetOnComplete (Action onComplete) : Tween<T>;
```

#### Set On Cancel

`version 1.3.0`

Sets the event which will be invoked when the tween is canceled.

```cs
<Tween>.SetOnCancel (Action onCancel) : Tween<T>;
```

#### Set Ping Pong

`version 1.6.0`

Enabled ping pong playback, this will bounce the animation back and forth. The tween has play forward and backwards to count as one cycle. Use either SetLoopCount or SetInifinite to set the number of times the animation should ping pong.

```cs
<Tween>.SetPingPong () : Tween<T>;
```

#### Set Loop Count

`version 1.2.0`

Sets the number of times the animation should loop.

```cs
<Tween>.SetLoopCount (int loopCount) : Tween<T>;
```

#### Set Infinite

`version 1.5.0`

Sets this tween to infinite, the loopcount will be ignored.

```cs
<Tween>.SetInfinite () : Tween<T>;
```

#### Set Delay

`version 1.3.0`

Sets the delay of this tween. The tween will not play anything until the requested delay time is reached. You can change this behaviour by enabeling 'goToFirstFrameImmediately' to set the animation to the first frame immediately.

```cs
<Tween>.SetDelay (float delay, bool goToFirstFrameImmediately = false) : Tween<T>;
```

#### Set Time

`version 1.1.0`

Sets the time of the tween.

```cs
<Tween>.SetTime (float time) : Tween<T>;
```

#### Set Random Time

`version 1.3.0`

Sets the time of the tween to a random value.

```cs
<Tween>.SetRandomTime () : Tween<T>;
```

#### Set Paused

`version 1.4.0`

Sets whether the playback and delay should be paused.

```cs
<Tween>.SetPaused (bool isPaused) : Tween<T>;
```

#### Set Use Unscaled Time

`version 1.6.1`

Sets whether the tween should use the unscaled delta time instead of the scaled delta time.

```cs
<Tween>.SetUseUnscaledTime (bool useUnscaledTime) : Tween<T>;
```

#### Set Overshooting

`version 1.5.0`

Sets the overshooting of Eases that exceed their boundaries such as elastic and back.

```cs
<Tween>.SetOvershooting (float overshooting) : Tween<T>;
```

#### Set Ease

`version 1.5.0`

Sets the ease for this tween.

```cs
<Tween>.SetEase (Ease ease) : Tween<T>;
```

#### Set Ease Linear

`version 1.0.0`

Sets the ease for this tween to Linear.

```cs
<Tween>.SetEaseLinear () : Tween<T>;
```

#### Set Ease Sine In

`version 1.0.0`

Sets the ease for this tween to SineIn.

```cs
<Tween>.SetEaseSineIn () : Tween<T>;
```

#### Set Ease Sine Out

`version 1.0.0`

Sets the ease for this tween to SineOut.

```cs
<Tween>.SetEaseSineOut () : Tween<T>;
```

#### Set Ease Sine In Out

`version 1.0.0`

Sets the ease for this tween to SineInOut.

```cs
<Tween>.SetEaseSineInOut () : Tween<T>;
```

#### Set Ease Quad In

`version 1.0.0`

Sets the ease for this tween to QuadIn.

```cs
<Tween>.SetEaseQuadIn () : Tween<T>;
```

#### Set Ease Quad Out

`version 1.0.0`

Sets the ease for this tween to QuadOut.

```cs
<Tween>.SetEaseQuadOut () : Tween<T>;
```

#### Set Ease Quad In Out

`version 1.0.0`

Sets the ease for this tween to QuadInOut.

```cs
<Tween>.SetEaseQuadInOut () : Tween<T>;
```

#### Set Ease Cubic In

`version 1.0.0`

Sets the ease for this tween to CubicIn.

```cs
<Tween>.SetEaseCubicIn () : Tween<T>;
```

#### Set Ease Cubic Out

`version 1.0.0`

Sets the ease for this tween to CubicOut.

```cs
<Tween>.SetEaseCubicOut () : Tween<T>;
```

#### Set Ease Cubic In Out

`version 1.0.0`

Sets the ease for this tween to CubicInOut.

```cs
<Tween>.SetEaseCubicInOut () : Tween<T>;
```

#### Set Ease Quart In

`version 1.0.0`

Sets the ease for this tween to QuartIn.

```cs
<Tween>.SetEaseQuartIn () : Tween<T>;
```

#### Set Ease Quart Out

`version 1.0.0`

Sets the ease for this tween to QuartOut.

```cs
<Tween>.SetEaseQuartOut () : Tween<T>;
```

#### Set Ease Quart In Out

`version 1.0.0`

Sets the ease for this tween to QuartInOut.

```cs
<Tween>.SetEaseQuartInOut () : Tween<T>;
```

#### Set Ease Quint In

`version 1.0.0`

Sets the ease for this tween to QuintIn.

```cs
<Tween>.SetEaseQuintIn () : Tween<T>;
```

#### Set Ease Quint Out

`version 1.0.0`

Sets the ease for this tween to QuintOut.

```cs
<Tween>.SetEaseQuintOut () : Tween<T>;
```

#### Set Ease Quint In Out

`version 1.0.0`

Sets the ease for this tween to QuintInOut.

```cs
<Tween>.SetEaseQuintInOut () : Tween<T>;
```

#### Set Ease Expo In

`version 1.0.0`

Sets the ease for this tween to ExpoIn.

```cs
<Tween>.SetEaseExpoIn () : Tween<T>;
```

#### Set Ease Expo Out

`version 1.0.0`

Sets the ease for this tween to ExpoOut.

```cs
<Tween>.SetEaseExpoOut () : Tween<T>;
```

#### Set Ease Expo In Out

`version 1.0.0`

Sets the ease for this tween to ExpoInOut.

```cs
<Tween>.SetEaseExpoInOut () : Tween<T>;
```

#### Set Ease Circ In

`version 1.0.0`

Sets the ease for this tween to CircIn.

```cs
<Tween>.SetEaseCircIn () : Tween<T>;
```

#### Set Ease Circ Out

`version 1.0.0`

Sets the ease for this tween to CircOut.

```cs
<Tween>.SetEaseCircOut () : Tween<T>;
```

#### Set Ease Circ In Out

`version 1.0.0`

Sets the ease for this tween to CircInOut.

```cs
<Tween>.SetEaseCircInOut () : Tween<T>;
```

#### Set Ease Back In

`version 1.0.0`

Sets the ease for this tween to BackIn.

```cs
<Tween>.SetEaseBackIn () : Tween<T>;
```

#### Set Ease Back Out

`version 1.0.0`

Sets the ease for this tween to BackOut.

```cs
<Tween>.SetEaseBackOut () : Tween<T>;
```

#### Set Ease Back In Out

`version 1.0.0`

Sets the ease for this tween to BackInOut.

```cs
<Tween>.SetEaseBackInOut () : Tween<T>;
```

#### Set Ease Elastic In

`version 1.0.0`

Sets the ease for this tween to ElasticIn.

```cs
<Tween>.SetEaseElasticIn () : Tween<T>;
```

#### Set Ease Elastic Out

`version 1.0.0`

Sets the ease for this tween to ElasticOut.

```cs
<Tween>.SetEaseElasticOut () : Tween<T>;
```

#### Set Ease Elastic In Out

`version 1.0.0`

Sets the ease for this tween to ElasticInOut.

```cs
<Tween>.SetEaseElasticInOut () : Tween<T>;
```

#### Set Ease Bounce In

`version 1.0.0`

Sets the ease for this tween to BounceIn.

```cs
<Tween>.SetEaseBounceIn () : Tween<T>;
```

#### Set Ease Bounce Out

`version 1.0.0`

Sets the ease for this tween to BounceOut.

```cs
<Tween>.SetEaseBounceOut () : Tween<T>;
```

#### Set Ease Bounce In Out

`version 1.0.0`

Sets the ease for this tween to BounceInOut.

```cs
<Tween>.SetEaseBounceInOut () : Tween<T>;
```

## Other Methods

#### Cancel

`version 1.0.0`

Cancel the tween.

```cs
<Tween>.Cancel () : void;
```

#### Yield

`version 1.9.0`

Returns a Task allowing the Tween to be awaited using an Async Await block.

```cs
<Tween>.Yield () : Task;
```

#### Get Total Duration

`version 1.6.2`

Gets the total duration of the tween including the loop count and ping pong settings, and the delay optionally.

```cs
<Tween>.GetTotalDuration (bool includeDelay = false) : float;
```
