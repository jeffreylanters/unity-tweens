using ElRaccoone.Tweens.Helpers;
using UnityEngine;

namespace ElRaccoone.Tweens.Core {
  public abstract class TweenMotor<T> : TweenBase {

    [HideInInspector] public T valueFrom = default (T);
    [HideInInspector] public T valueTo = default (T);
    [HideInInspector] public T valueCurrent = default (T);

    private float time = 0;
    private float duration = 0;
    private Ease ease = 0;
    private bool didOverwriteFrom = false;
    private bool isPingPongEnabled = false;
    private bool isPlayingForward = true;
    private int loopCount = 0;

    public abstract T OnGetFrom ();
    public abstract void OnUpdate (float easedTime);

    private void Awake () {
      if (this.didOverwriteFrom == false)
        this.valueFrom = this.OnGetFrom ();
    }

    private void Update () {
      var _timeDelta = Time.deltaTime / this.duration;
      if (this.isPingPongEnabled == true) {
        this.time += this.isPlayingForward == true ? _timeDelta : -_timeDelta;
        if (this.time > 1) {
          this.isPlayingForward = false;
          this.time = 1;
        } else if (this.time < 0) {
          this.isPlayingForward = true;
          this.time = 0;
        }
        this.OnUpdate (EasingMethods.Apply (this.ease, this.time));
      } else {
        this.time += _timeDelta;
        if (this.time >= 1)
          this.time = 1;
        this.OnUpdate (EasingMethods.Apply (this.ease, this.time));
        if (this.time == 1) {
          if (this.loopCount > 0) {
            this.loopCount -= 1;
            this.time = 0;
          } else {
            Object.Destroy (this);
          }
        }
      }
    }

    public float InterpolateValue (float from, float to, float time) {
      return from * (1 - time) + to * time;
    }

    public TweenMotor<T> Finalize (float duration, T valueTo) {
      this.duration = duration;
      this.valueTo = valueTo;
      return this;
    }

    public TweenMotor<T> SetFrom (T valueFrom) {
      this.didOverwriteFrom = true;
      this.valueFrom = valueFrom;
      return this;
    }

    public TweenMotor<T> SetPingPong () {
      this.isPingPongEnabled = true;
      return this;
    }

    public TweenMotor<T> SetLoopCount (int loopCount) {
      this.loopCount = loopCount;
      return this;
    }

    public TweenMotor<T> SetEaseLinear () {
      this.ease = Ease.Linear;
      return this;
    }

    public TweenMotor<T> SetEaseSineIn () {
      this.ease = Ease.SineIn;
      return this;
    }

    public TweenMotor<T> SetEaseSineOut () {
      this.ease = Ease.SineOut;
      return this;
    }

    public TweenMotor<T> SetEaseSineInOut () {
      this.ease = Ease.SineInOut;
      return this;
    }

    public TweenMotor<T> SetEaseBackIn () {
      this.ease = Ease.BackIn;
      return this;
    }

    public TweenMotor<T> SetEaseBackOut () {
      this.ease = Ease.BackOut;
      return this;
    }

    public TweenMotor<T> SetEaseBackInOut () {
      this.ease = Ease.BackInOut;
      return this;
    }
  }
}