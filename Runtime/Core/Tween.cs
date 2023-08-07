using System;
using System.Threading;
using System.Threading.Tasks;
using Tweens.Core.Data;
using UnityEngine;

namespace Tweens.Core {
  public abstract class Tween {
    public float duration;
    public float time;
    public SetValue<float> delay = new();
    public bool useScaledTime = true;
    public bool isPaused;
    public bool usePingPong;
    public bool isInfinite;
    public SetValue<int> loops = new();
    public EaseType easeType;
    public CompletableValue<Action> onStart = new();
    public SetValue<Action> onEnd = new();
    public CompletableValue<Action> onCancel = new();
    internal readonly GameObject gameObject;
    internal bool isForwards = true;
    internal bool didReachEnd;
    internal CancellationTokenSource cancellationTokenSource = new();
    internal CancellationToken cancellationToken;

    public Tween(GameObject target) {
      gameObject = target;
      cancellationToken = cancellationTokenSource.Token;
      TweenEngine.Register(this);
    }

    internal virtual void Awake() {
      if (duration <= 0) {
        duration = 0.001f;
      }
    }

    internal virtual void Update() {
      if (isPaused) {
        return;
      }
      var deltaTime = useScaledTime ? Time.deltaTime : Time.unscaledDeltaTime;
      if (delay.IsSet) {
        delay -= deltaTime;
        if (delay <= 0) {
          delay.Unset();
        }
        return;
      }
      if (onStart.IsSet && !onStart.DidComplete) {
        onStart.value.Invoke();
        onStart.Complete();
      }
      var timeStep = deltaTime / duration;
      time += isForwards ? timeStep : -timeStep;
      if (time >= 1) {
        time = 1;
        if (usePingPong) {
          isForwards = false;
        }
        else if (!isInfinite) {
          didReachEnd = true;
        }
        else {
          time = 0;
        }
      }
      else if (usePingPong && time < 0) {
        time = 0;
        isForwards = true;
        if (!isInfinite) {
          didReachEnd = true;
        }
      }
      if (didReachEnd) {
        if (loops.IsSet && loops > 1) {
          didReachEnd = false;
          loops -= 1;
          time = 0;
        }
        else {
          if (onEnd.IsSet) {
            onEnd.value.Invoke();
          }
          Cleanup();
        }
      }
    }

    internal void Cleanup() {
      cancellationTokenSource.Cancel();
      TweenEngine.Unregister(this);
    }

    internal float Interpolate(float from, float to, float time) {
      if (time > 1)
        time -= (time - 1) / 1;
      else if (this.time < 0)
        time -= time / 1;
      return from * (1 - time) + to * time;
    }

    public async Task Async() {
      while (!cancellationToken.IsCancellationRequested) {
        await Task.Yield();
      }
    }

    public void Cancel() {
      if (onCancel.IsSet && !onCancel.DidComplete) {
        onCancel.value.Invoke();
        onCancel.Complete();
      }
      Cleanup();
    }
  }
}