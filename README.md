<div align="center">

![readme splash](https://raw.githubusercontent.com/jeffreylanters/unity-tweens/master/.github/WIKI/repository-readme-splash.png)

[![license](https://img.shields.io/badge/mit-license-red.svg?style=for-the-badge)](https://github.com/jeffreylanters/unity-tweens/blob/master/LICENSE.md)
[![openupm](https://img.shields.io/npm/v/nl.jeffreylanters.tweens?label=UPM&registry_uri=https://package.openupm.com&style=for-the-badge&color=232c37)](https://openupm.com/packages/nl.jeffreylanters.tweens/)
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
"nl.jeffreylanters.tweens": "git+https://github.com/jeffreylanters/unity-tweens"
```

### Using OpenUPM

The module is availble on the OpenUPM package registry, you can install the latest stable release using the OpenUPM Package manager's Command Line Tool using the following command.

```sh
openupm add nl.jeffreylanters.tweens
```

# Documentation

This module is benchmarked against other great tweening libraries LeanTween and ITween and outperforms both while running 1000 complex tweens simulataniously. The power and speed you expect, with a modern strictly typed API, clean and ease-to-use options for all your tweening needs.

- [Getting Started](#getting-started) - Code examples on how to create your first Tween

## Getting Started

To get started, create a new instance of one of the many available tween types and add it to a GameObject. The following example shows how to create a new PositionTween and add it to a GameObject.

```cs
PositionTween tween = new() {
  to = new Vector3(10, 5, 20),
  duration = 10,
  delay = 2,
  easeType = EaseType.SineInOut,
};
gameObject.AddTween(tween);
```
