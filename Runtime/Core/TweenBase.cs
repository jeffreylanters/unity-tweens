using ElRaccoone.Tweens.Helpers;
using UnityEngine;

namespace ElRaccoone.Tweens.Core {
  public abstract class TweenBase<T> : TweenInstance {
    internal T valueFrom = default (T);
    internal T valueTo = default (T);
    internal T valueCurrent = default (T);

    private float time = 0;
    private int loopCount = 0;
    private Ease ease = 0;

    private bool hasDuration = false;
    private float duration = 0;

    private bool hasDelay = false;
    private float delay = 0;

    private bool hasOvershooting = false;
    private float overshooting = 0;

    private bool didOverwriteFrom = false;
    private bool isLoopPingPongEnabled = false;
    private bool isPlayingForward = true;

    public abstract bool OnInitialize ();
    public abstract T OnGetFrom ();
    public abstract void OnUpdate (float easedTime);

    private void Start () {
      // When From is not overwritten and the Tween has no delay, the valueFrom
      // is requested from the inheriter. Then the animation will be set to its
      // first frame.
      if (this.OnInitialize () == false) {
        this.Decommission ();
      } else if (this.didOverwriteFrom == false && this.hasDelay == false) {
        this.valueFrom = this.OnGetFrom ();
        this.OnUpdate (EasingMethods.Apply (this.ease, 0));
      }
    }

    private void Update () {
      // When the tween is decommissioned, tweening is aborted.
      if (this.isDecommissioned == true)
        return;
      // When the delay is active, the tween will wait for the delay to pass by.
      if (this.hasDelay == true) {
        this.delay -= Time.deltaTime;
        if (this.delay <= 0) {
          this.hasDelay = false;
          // When the delay is over, the valueFrom is requested from the 
          // inheriter. Then the animation will be set to its first frame.
          if (this.didOverwriteFrom == false) {
            this.valueFrom = this.OnGetFrom ();
            this.OnUpdate (EasingMethods.Apply (this.ease, 0));
          }
        }
      }

      // When the tween has no duration, the timing will not be done and the
      // animation will be set to its last frame amd decomissioned right away.
      else if (this.hasDuration == false) {
        this.OnUpdate (EasingMethods.Apply (this.ease, 1));
        this.Decommission ();
        return;
      }

      // When the tween has a loop type of ping pong, the time will be bounced
      // back and forth between 0 and 1 endlessly until decomissioned.
      else if (this.isLoopPingPongEnabled == true) {
        var _timeDelta = Time.deltaTime / this.duration;
        this.time += this.isPlayingForward == true ? _timeDelta : -_timeDelta;
        if (this.time > 1) {
          this.isPlayingForward = false;
          this.time = 1;
        } else if (this.time < 0) {
          this.isPlayingForward = true;
          this.time = 0;
        }
        this.OnUpdate (EasingMethods.Apply (this.ease, this.time));
      }

      // Otherwise the tween will play its regular animation cycle. When the
      // loop count exceeds, the tween will be decomissioned.
      else {
        this.time += Time.deltaTime / this.duration;
        if (this.time >= 1)
          this.time = 1;
        this.OnUpdate (EasingMethods.Apply (this.ease, this.time));
        if (this.time == 1) {
          if (this.loopCount > 0) {
            this.loopCount -= 1;
            this.time = 0;
          } else
            this.Decommission ();
        }
      }
    }

    // Returns the interpolated value of time between from and to.
    internal float InterpolateValue (float from, float to, float time) {
      if (this.hasOvershooting == true) {
        if (time > 1)
          time -= (time - 1) / (this.overshooting + 1);
        else if (time < 0)
          time -= time / (this.overshooting + 1);
      }
      return from * (1 - time) + to * time;
    }

    /// Sets the final values required for the tween can start.
    internal TweenBase<T> Finalize (float duration, T valueTo) {
      this.duration = duration;
      this.hasDuration = duration > 0;
      this.valueTo = valueTo;
      // this.hideFlags = HideFlags.HideInInspector;
      return this;
    }

    /// Sets the value this tween should animate from instead of its current.
    public TweenBase<T> SetFrom (T valueFrom) {
      this.didOverwriteFrom = true;
      this.valueFrom = valueFrom;
      return this;
    }

    /// Sets the loop type to ping pong, this will bounce the animation back
    /// and forth endlessly. This type hides the LoopCount value.
    public TweenBase<T> SetLoopPingPong () {
      this.isLoopPingPongEnabled = true;
      return this;
    }

    /// Sets the loop count of this tween until it can be decomissioned.
    public TweenBase<T> SetLoopCount (int loopCount) {
      this.loopCount = loopCount;
      return this;
    }

    /// Sets the delay of this tween. The tween will not play anything until
    /// the requested delay time is reached.
    public TweenBase<T> SetDelay (float delay) {
      this.delay = delay;
      this.hasDelay = true;
      return this;
    }

    /// Sets the overshooting of Eases that exceed their boundaries such as
    /// elastic and back.
    public TweenBase<T> SetOvershooting (float overshooting) {
      this.overshooting = overshooting;
      this.hasOvershooting = true;
      return this;
    }

    /// Sets the ease for this tween.
    public TweenBase<T> SetEase (Ease ease) {
      this.ease = ease;
      return this;
    }

    public TweenBase<T> SetEaseLinear () {
      this.ease = Ease.Linear;
      return this;
    }

    public TweenBase<T> SetEaseSineIn () {
      this.ease = Ease.SineIn;
      return this;
    }

    public TweenBase<T> SetEaseSineOut () {
      this.ease = Ease.SineOut;
      return this;
    }

    public TweenBase<T> SetEaseSineInOut () {
      this.ease = Ease.SineInOut;
      return this;
    }

    public TweenBase<T> SetEaseQuadIn () {
      this.ease = Ease.QuadIn;
      return this;
    }

    public TweenBase<T> SetEaseQuadOut () {
      this.ease = Ease.QuadOut;
      return this;
    }

    public TweenBase<T> SetEaseQuadInOut () {
      this.ease = Ease.QuadInOut;
      return this;
    }

    public TweenBase<T> SetEaseCubicIn () {
      this.ease = Ease.CubicIn;
      return this;
    }

    public TweenBase<T> SetEaseCubicOut () {
      this.ease = Ease.CubicOut;
      return this;
    }

    public TweenBase<T> SetEaseCubicInOut () {
      this.ease = Ease.CubicInOut;
      return this;
    }

    public TweenBase<T> SetEaseQuartIn () {
      this.ease = Ease.QuartIn;
      return this;
    }

    public TweenBase<T> SetEaseQuartOut () {
      this.ease = Ease.QuartOut;
      return this;
    }

    public TweenBase<T> SetEaseQuartInOut () {
      this.ease = Ease.QuartInOut;
      return this;
    }

    public TweenBase<T> SetEaseQuintIn () {
      this.ease = Ease.QuintIn;
      return this;
    }

    public TweenBase<T> SetEaseQuintOut () {
      this.ease = Ease.QuintOut;
      return this;
    }

    public TweenBase<T> SetEaseQuintInOut () {
      this.ease = Ease.QuintInOut;
      return this;
    }

    public TweenBase<T> SetEaseExpoIn () {
      this.ease = Ease.ExpoIn;
      return this;
    }

    public TweenBase<T> SetEaseExpoOut () {
      this.ease = Ease.ExpoOut;
      return this;
    }

    public TweenBase<T> SetEaseExpoInOut () {
      this.ease = Ease.ExpoInOut;
      return this;
    }

    public TweenBase<T> SetEaseCircIn () {
      this.ease = Ease.CircIn;
      return this;
    }

    public TweenBase<T> SetEaseCircOut () {
      this.ease = Ease.CircOut;
      return this;
    }

    public TweenBase<T> SetEaseCircInOut () {
      this.ease = Ease.CircInOut;
      return this;
    }

    public TweenBase<T> SetEaseBackIn () {
      this.ease = Ease.BackIn;
      return this;
    }

    public TweenBase<T> SetEaseBackOut () {
      this.ease = Ease.BackOut;
      return this;
    }

    public TweenBase<T> SetEaseBackInOut () {
      this.ease = Ease.BackInOut;
      return this;
    }

    public TweenBase<T> SetEaseElasticIn () {
      this.ease = Ease.ElasticIn;
      return this;
    }

    public TweenBase<T> SetEaseElasticOut () {
      this.ease = Ease.ElasticOut;
      return this;
    }

    public TweenBase<T> SetEaseElasticInOut () {
      this.ease = Ease.ElasticInOut;
      return this;
    }

    public TweenBase<T> SetEaseBounceIn () {
      this.ease = Ease.BounceIn;
      return this;
    }

    public TweenBase<T> SetEaseBounceOut () {
      this.ease = Ease.BounceOut;
      return this;
    }

    public TweenBase<T> SetEaseBounceInOut () {
      this.ease = Ease.BounceInOut;
      return this;
    }
  }
}