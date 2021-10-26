<div align="center">

![readme splash](https://raw.githubusercontent.com/jeffreylanters/unity-tweens/master/.github/WIKI/repository-readme-splash.png)

[![license](https://img.shields.io/badge/mit-license-red.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-tweens/blob/master/LICENSE.md)
[![openupm](https://img.shields.io/npm/v/nl.elraccoone.tweens?label=UPM&registry_uri=https://package.openupm.com&style=for-the-badge&color=232c37)](https://openupm.com/packages/nl.elraccoone.tweens/)
[![build](https://img.shields.io/badge/build-passing-brightgreen.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-tweens/actions)
[![deployment](https://img.shields.io/badge/state-success-brightgreen.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-tweens/deployments)
[![stars](https://img.shields.io/github/stars/jeffreylanters/unity-tweens.svg?style=for-the-badge&color=fe8523&label=stargazers)](https://github.com/jeffreylanters/unity-tweens/stargazers)
[![awesome](https://img.shields.io/badge/listed-awesome-fc60a8.svg?style=for-the-badge)](https://github.com/jeffreylanters/awesome-unity-packages)
[![size](https://img.shields.io/github/languages/code-size/jeffreylanters/unity-tweens?style=for-the-badge)](https://github.com/jeffreylanters/unity-tweens/blob/master/Runtime)
[![sponsors](https://img.shields.io/github/sponsors/jeffreylanters?color=E12C9A&style=for-the-badge)](https://github.com/sponsors/jeffreylanters)
[![donate](https://img.shields.io/badge/donate-paypal-F23150?style=for-the-badge)](https://paypal.me/jeffreylanters)

An extremely light weight, extendable and customisable tweening engine made for strictly typed script-based animations for user-interfaces and world-space objects optimised for all platforms.

[**Installation**](#installation) &middot;
[**Documentation**](#documentation) &middot;
[**License**](./LICENSE.md)

**Made with &hearts; by Jeffrey Lanters**

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

- [Getting Started](#getting-started) - Code examples on how to create your first Tween
- [Tweening Methods](#tweening-methods) - Tweening methods available to animate various properties
- [Chainable Options](#chainable-options) - Chainable options allowing you to alter the Tween's behaviour
- [Other Methods](#other-methods) - Various other options available on instanciated Tweens

## Getting Started

These are some of the endless possibilities using Tweens. Tweens can be invoked on any GameObject and Component and fetches their own required components so you don't have to. Chainable Options can used endlessly in order to customize the behaviour to your needs.

```cs
using UnityEngine;
using ElRaccoone.Tweens;

public class SomeComponent : MonoBehaviour {
  private void Start () {
    this.gameObject.TweenPosition (new Vector3  (10, 1, 15), 5).SetFrom (Vector3.zero).SetOnComplete (SomeMethod);
    this.gameObject.TweenAnchoredPositionX (100, 2).SetPingPong ().SetLoopCount (2);
    this.gameObject.TweenLocalRotation (Vector3.one * 360, 10).SetDelay (10).SetEaseSineOut ();
    this.gameObject.TweenImageFillAmount (0.75, 2).SetEaseQuartInOut ().SetRandomTime ();
    this.gameObject.TweenMaterialColor (Color.red, 10).SetUseUnscaledTime (false).SetEaseCircInOut ();
    this.gameObject.TweenLightIntensity (10, 1).SetInfinite ().SetRandomTime ().SetOnCancel (SomeOtherMethod);
    this.gameObject.TweenCancelAll ();
  }

  private async void AsyncAnimationSequence () {
    await this.gameObject.TweenCanvasGroupAlpha (0, 1).SetEaseElasticIn ().SetOvershooting (2).Await ();
    await this.gameObject.TweenVolumeWeight (50, 2).SetTime (0.25f).SetEaseExpoOut ().Await ();
  }

  private IEnumerator RoutineAnimationSequence () {
    yield return this.gameObject.TweenAudioSourcePriority (5, 10).SetEase (EaseType.BounceInOut).Yield ();
    yield return this.gameObject.TweenValueFloat (100, 1, value => { }).SetFrom (100).SetEaseSineIn ().Yield ();
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

#### Tween Image Fill Amount (Unity GUI)

`version 1.0.3`

`requires com.unity.ugui`

Instantiates a Tween animating the fillAmount of an image.

```cs
<GameObject, Component>.TweenImageFillAmount (float to, float duration) : Tween<float>;
```

#### Tween Graphic Alpha (Unity GUI)

`version 1.0.4`

`requires com.unity.ugui`

Instantiates a Tween animating the alpha of a graphic.

```cs
<GameObject, Component>.TweenGraphicAlpha (float to, float duration) : Tween<float>;
```

#### Tween Graphic Color (Unity GUI)

`version 1.0.4`

`requires com.unity.ugui`

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

#### Tween Audio Source Pitch

`version 1.0.11`

Instantiates a Tween easing the pitch of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourcePitch (float to, float duration) : Tween<float>;
```

#### Tween Audio Source Priority

`version 1.10.0`

Instantiates a Tween easing the priority of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourcePriority (float to, float duration) : Tween<float>;
```

#### Tween Audio Source Reverb Zone Mix

`version 1.10.0`

Instantiates a Tween easing the reverb zone mix of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourceReverbZoneMix (float to, float duration) : Tween<float>;
```

#### Tween Audio Source Spatial Blend

`version 1.10.0`

Instantiates a Tween easing the spatial blend of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourceSpatialBlend (float to, float duration) : Tween<float>;
```

#### Tween Audio Source Stereo Pan

`version 1.10.0`

Instantiates a Tween easing the stereo pan of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourceStereoPan (float to, float duration) : Tween<float>;
```

#### Tween Audio Source Volume

`version 1.0.11`

Instantiates a Tween easing the volume of an AudioSource.

```cs
<GameObject, Component>.TweenAudioSourceVolume (float to, float duration) : Tween<float>;
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

#### Tween Light Intensity

`version 1.9.3`

Instantiates a Tween easing the intensity of a Light.

```cs
<GameObject, Component>.TweenLightIntensity (float to, float duration) : Tween<float>;
```

#### Tween Light Range

`version 1.11.0`

Instantiates a Tween easing the range of a Light.

```cs
<GameObject, Component>.TweenLightRange (float to, float duration) : Tween<float>;
```

#### Tween Light Spot Angle

`version 1.11.0`

Instantiates a Tween easing the spot angle of a Light.

```cs
<GameObject, Component>.TweenLightSpotAngle (float to, float duration) : Tween<float>;
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
<Tween<T>>.SetFrom (T valueFrom) : Tween<T>;
```

#### Set On Complete

`version 1.1.0`

Sets the event which will be invoked when the tween completes playing. This will
not be invoked when the tween is canceled.

```cs
<Tween<T>>.SetOnComplete (Action onComplete) : Tween<T>;
```

#### Set On Cancel

`version 1.3.0`

Sets the event which will be invoked when the tween is canceled.

```cs
<Tween<T>>.SetOnCancel (Action onCancel) : Tween<T>;
```

#### Set Ping Pong

`version 1.6.0`

Enabled ping pong playback, this will bounce the animation back and forth. The tween has play forward and backwards to count as one cycle. Use either SetLoopCount or SetInifinite to set the number of times the animation should ping pong.

```cs
<Tween<T>>.SetPingPong () : Tween<T>;
```

#### Set Loop Count

`version 1.2.0`

Sets the number of times the animation should loop.

```cs
<Tween<T>>.SetLoopCount (int loopCount) : Tween<T>;
```

#### Set Infinite

`version 1.5.0`

Sets this tween to infinite, the loopcount will be ignored.

```cs
<Tween<T>>.SetInfinite () : Tween<T>;
```

#### Set Delay

`version 1.3.0`

Sets the delay of this tween. The tween will not play anything until the requested delay time is reached. You can change this behaviour by enabeling 'goToFirstFrameImmediately' to set the animation to the first frame immediately.

```cs
<Tween<T>>.SetDelay (float delay, bool goToFirstFrameImmediately = false) : Tween<T>;
```

#### Set Time

`version 1.1.0`

Sets the time of the tween.

```cs
<Tween<T>>.SetTime (float time) : Tween<T>;
```

#### Set Random Time

`version 1.3.0`

Sets the time of the tween to a random value.

```cs
<Tween<T>>.SetRandomTime () : Tween<T>;
```

#### Set Paused

`version 1.4.0`

Sets whether the playback and delay should be paused.

```cs
<Tween<T>>.SetPaused (bool isPaused) : Tween<T>;
```

#### Set Use Unscaled Time

`version 1.6.1`

Sets whether the tween should use the unscaled delta time instead of the scaled delta time.

```cs
<Tween<T>>.SetUseUnscaledTime (bool useUnscaledTime) : Tween<T>;
```

#### Set Overshooting

`version 1.5.0`

Sets the overshooting of Eases that exceed their boundaries such as elastic and back.

```cs
<Tween<T>>.SetOvershooting (float overshooting) : Tween<T>;
```

#### Set Ease

`version 1.5.0`

Sets the ease for this tween.

```cs
<Tween<T>>.SetEase (EaseType ease) : Tween<T>;
```

#### Set Ease Linear

`version 1.0.0`

Sets the ease for this tween to Linear.

```cs
<Tween<T>>.SetEaseLinear () : Tween<T>;
```

#### Set Ease Sine In

`version 1.0.0`

Sets the ease for this tween to SineIn.

```cs
<Tween<T>>.SetEaseSineIn () : Tween<T>;
```

#### Set Ease Sine Out

`version 1.0.0`

Sets the ease for this tween to SineOut.

```cs
<Tween<T>>.SetEaseSineOut () : Tween<T>;
```

#### Set Ease Sine In Out

`version 1.0.0`

Sets the ease for this tween to SineInOut.

```cs
<Tween<T>>.SetEaseSineInOut () : Tween<T>;
```

#### Set Ease Quad In

`version 1.0.0`

Sets the ease for this tween to QuadIn.

```cs
<Tween<T>>.SetEaseQuadIn () : Tween<T>;
```

#### Set Ease Quad Out

`version 1.0.0`

Sets the ease for this tween to QuadOut.

```cs
<Tween<T>>.SetEaseQuadOut () : Tween<T>;
```

#### Set Ease Quad In Out

`version 1.0.0`

Sets the ease for this tween to QuadInOut.

```cs
<Tween<T>>.SetEaseQuadInOut () : Tween<T>;
```

#### Set Ease Cubic In

`version 1.0.0`

Sets the ease for this tween to CubicIn.

```cs
<Tween<T>>.SetEaseCubicIn () : Tween<T>;
```

#### Set Ease Cubic Out

`version 1.0.0`

Sets the ease for this tween to CubicOut.

```cs
<Tween<T>>.SetEaseCubicOut () : Tween<T>;
```

#### Set Ease Cubic In Out

`version 1.0.0`

Sets the ease for this tween to CubicInOut.

```cs
<Tween<T>>.SetEaseCubicInOut () : Tween<T>;
```

#### Set Ease Quart In

`version 1.0.0`

Sets the ease for this tween to QuartIn.

```cs
<Tween<T>>.SetEaseQuartIn () : Tween<T>;
```

#### Set Ease Quart Out

`version 1.0.0`

Sets the ease for this tween to QuartOut.

```cs
<Tween<T>>.SetEaseQuartOut () : Tween<T>;
```

#### Set Ease Quart In Out

`version 1.0.0`

Sets the ease for this tween to QuartInOut.

```cs
<Tween<T>>.SetEaseQuartInOut () : Tween<T>;
```

#### Set Ease Quint In

`version 1.0.0`

Sets the ease for this tween to QuintIn.

```cs
<Tween<T>>.SetEaseQuintIn () : Tween<T>;
```

#### Set Ease Quint Out

`version 1.0.0`

Sets the ease for this tween to QuintOut.

```cs
<Tween<T>>.SetEaseQuintOut () : Tween<T>;
```

#### Set Ease Quint In Out

`version 1.0.0`

Sets the ease for this tween to QuintInOut.

```cs
<Tween<T>>.SetEaseQuintInOut () : Tween<T>;
```

#### Set Ease Expo In

`version 1.0.0`

Sets the ease for this tween to ExpoIn.

```cs
<Tween<T>>.SetEaseExpoIn () : Tween<T>;
```

#### Set Ease Expo Out

`version 1.0.0`

Sets the ease for this tween to ExpoOut.

```cs
<Tween<T>>.SetEaseExpoOut () : Tween<T>;
```

#### Set Ease Expo In Out

`version 1.0.0`

Sets the ease for this tween to ExpoInOut.

```cs
<Tween<T>>.SetEaseExpoInOut () : Tween<T>;
```

#### Set Ease Circ In

`version 1.0.0`

Sets the ease for this tween to CircIn.

```cs
<Tween<T>>.SetEaseCircIn () : Tween<T>;
```

#### Set Ease Circ Out

`version 1.0.0`

Sets the ease for this tween to CircOut.

```cs
<Tween<T>>.SetEaseCircOut () : Tween<T>;
```

#### Set Ease Circ In Out

`version 1.0.0`

Sets the ease for this tween to CircInOut.

```cs
<Tween<T>>.SetEaseCircInOut () : Tween<T>;
```

#### Set Ease Back In

`version 1.0.0`

Sets the ease for this tween to BackIn.

```cs
<Tween<T>>.SetEaseBackIn () : Tween<T>;
```

#### Set Ease Back Out

`version 1.0.0`

Sets the ease for this tween to BackOut.

```cs
<Tween<T>>.SetEaseBackOut () : Tween<T>;
```

#### Set Ease Back In Out

`version 1.0.0`

Sets the ease for this tween to BackInOut.

```cs
<Tween<T>>.SetEaseBackInOut () : Tween<T>;
```

#### Set Ease Elastic In

`version 1.0.0`

Sets the ease for this tween to ElasticIn.

```cs
<Tween<T>>.SetEaseElasticIn () : Tween<T>;
```

#### Set Ease Elastic Out

`version 1.0.0`

Sets the ease for this tween to ElasticOut.

```cs
<Tween<T>>.SetEaseElasticOut () : Tween<T>;
```

#### Set Ease Elastic In Out

`version 1.0.0`

Sets the ease for this tween to ElasticInOut.

```cs
<Tween<T>>.SetEaseElasticInOut () : Tween<T>;
```

#### Set Ease Bounce In

`version 1.0.0`

Sets the ease for this tween to BounceIn.

```cs
<Tween<T>>.SetEaseBounceIn () : Tween<T>;
```

#### Set Ease Bounce Out

`version 1.0.0`

Sets the ease for this tween to BounceOut.

```cs
<Tween<T>>.SetEaseBounceOut () : Tween<T>;
```

#### Set Ease Bounce In Out

`version 1.0.0`

Sets the ease for this tween to BounceInOut.

```cs
<Tween<T>>.SetEaseBounceInOut () : Tween<T>;
```

## Other Methods

#### Cancel

`version 1.0.0`

Cancel the tween.

```cs
<Tween<T>>.Cancel () : void;
```

#### Await

`version 1.9.1`

Returns a Task allowing the Tween to be awaited using an Async Await block until the Tween is either completed, destroyed, canceld or was unable to start. Make sure to cancel your Async method to prevent errors from being throwing in the Unity Editor when leaving Play mode while using Tasks to chain a sequence of Tweens.

```cs
<Tween<T>>.Await () : Task;
```

#### Yield

`version 1.9.1`

Returns a IEnumerator allowing the Tween to be yielded using a coroutine until the Tween is either completed, destroyed, canceld or was unable to start.

```cs
<Tween<T>>.Yield () : IEnumerator;
```

#### Get Total Duration

`version 1.6.2`

Gets the total duration of the tween including the loop count and ping pong settings, and the delay optionally.

```cs
<Tween<T>>.GetTotalDuration (bool includeDelay = false) : float;
```
