using System.Threading;
using UnityEngine;
using Tweens.Core;

namespace Tweens {
  public abstract class TweenInstance {
    public GameObject target;
    public bool isPaused;
    internal float duration;
    internal float? delay;
    internal bool useScaledTime = true;
    internal bool usePingPong;
    internal bool isInfinite;
    internal int? loops;
    internal EaseType easeType;
    internal float time;
    internal bool isForwards = true;
    internal bool didReachEnd;
    internal CancellationTokenSource cancellationTokenSource = new();
    internal CancellationToken cancellationToken;

    internal abstract void Update();
    public abstract void Cancel();

    internal TweenInstance(GameObject target) {
      this.target = target;
      cancellationToken = cancellationTokenSource.Token;
    }

    internal void Cleanup() {
      cancellationTokenSource.Cancel();
      TweenEngine.Remove(this);
    }
  }
}