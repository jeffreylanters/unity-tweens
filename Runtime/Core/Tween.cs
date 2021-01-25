using System;
using UnityEngine;

namespace ElRaccoone.Tweens.Core {
  
  /// Types abstract class for all core Tween functionality.
  public abstract class Tween<DriverValueType> : MonoBehaviour, ITween {

    /// The value the driver should Tween from.
    internal DriverValueType valueFrom = default (DriverValueType);

    /// The value the driver should Tween to.
    internal DriverValueType valueTo = default (DriverValueType);

    /// The state value the driving is currently tweening at.
    internal DriverValueType valueCurrent = default (DriverValueType);

    /// Defines whether the Tween is paused.
    private bool isPaused = false;

    /// The current play-time of the Tween.
    private float time = 0;

    /// The Eas type of the Tween defining the style of animation.
    private EaseType ease = 0;

    /// Defines whether the Tween is decommissioned, when set to true the Tween
    /// will be stopped and destroyed as soon as possible. All playback will stop.
    private bool isDecommissioned = false;

    /// Defines whether the Tween should play infinitly.
    private bool isInfinite = false;

    /// Defines whether the from value has been overwritten. If not, the initial
    /// value will be used to free from. This is defined by the Driver.
    private bool didOverwriteFrom = false;

    /// Defines whether the Tween uses ping pong during it's animation. When set
    /// to true, the twee will play back and forth. Going once forth and once
    /// back counts as one cycle.
    private bool hasPingPong = false;

    /// Defines whether the Tween is playing forward, this is only used for the
    /// ping pong mechanic.
    private bool isPlayingForward = true;

    /// Defines whether the Tween did reach the end time. If true, and no other
    /// values such as ping pong or infinite will overwrite it, the Tween will
    /// be decommissioned.
    private bool timeDidReachEnd = false;

    /// Defines whether the Tween should use the unscale time, if false, scaled
    /// time will be used by default.
    private bool useUnscaledTime = false;

    /// Defines whether the Tween has a loop count, if true the Tween will keep
    /// re-playing until the loop count hits zero. When ping pong is enbaled,
    /// a play forth and back counts as a single loop.
    private bool hasLoopCount = false;

    /// The value of the loop count. When the loop count is used the Tween will 
    /// keep re-playing until the loop count hits zero. When ping pong is enbaled,
    /// a play forth and back counts as a single loop.
    private int loopCount = 0;

    private bool hasDuration = false;
    private float duration = 0;

    private bool hasDelay = false;
    private float delay = 0;
    private bool goToFirstFrameImmediately = false;

    private bool hasOvershooting = false;
    private float overshooting = 0;

    private Action onComplete = null;
    private bool hasOnComplete = false;

    private Action onCancel = null;
    private bool hasOnCancel = false;

    public abstract bool OnInitialize ();
    public abstract DriverValueType OnGetFrom ();
    public abstract void OnUpdate (float easedTime);

    private void Start () {
      // Invokes the OnInitialize on the Tween driver. If returned false, the
      // Tween is not ready to play or is incompatible. Then we'll decommission.
      if (this.OnInitialize () == false)
        this.Decommission ();
      // When From is not overwritten and the Tween has no delay, the valueFrom
      // is requested from the inheriter. Then the animation will be set to its
      // first frame. This is done during the Start method so other parameters
      // can be set.
      else if (this.hasDelay == false || this.goToFirstFrameImmediately == true) {
        if (this.didOverwriteFrom == false)
          this.valueFrom = this.OnGetFrom ();
        this.OnUpdate (Easer.Apply (this.ease, 0));
      }
    }

    // When the object is disabled, but the tween did not finish, decommission.
    private void OnDisable () {
      if (this.timeDidReachEnd == false)
        this.Decommission ();
    }

    private void Update () {
      // When the tween is decommissioned, tweening is aborted.
      if (this.isDecommissioned == true)
        return;
      // When the tween is paused, we'll just wait.
      if (this.isPaused == true)
        return;
      // When the delay is active, the tween will wait for the delay to pass by.
      if (this.hasDelay == true) {
        this.delay -= this.useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime;
        if (this.delay <= 0) {
          this.hasDelay = false;
          // When the delay is over, the valueFrom is requested from the 
          // inheriter. Then the animation will be set to its first frame.
          if (this.didOverwriteFrom == false)
            this.valueFrom = this.OnGetFrom ();
          this.OnUpdate (Easer.Apply (this.ease, 0));
        }
      }
      // When the tween has no duration, the timing will not be done and the
      // animation will be set to its last frame amd decomissioned right away.
      else if (this.hasDuration == false) {
        this.OnUpdate (Easer.Apply (this.ease, 1));
        this.Decommission ();
        return;
      }
      // Oterwise it is... Showtime!
      else {
        // Increase or decrease the time of the tween based on the direction.
        var _timeDelta = (this.useUnscaledTime ? Time.unscaledDeltaTime : Time.deltaTime) / this.duration;
        this.time += this.isPlayingForward == true ? _timeDelta : -_timeDelta;
        // The time will be capped to 1, when pingpong is enabled the tween will
        // play backwards, otherwise when the tween is not infinite, didReachEnd
        // will be set to true.
        if (this.time > 1) {
          this.time = 1;
          if (this.hasPingPong == true)
            this.isPlayingForward = false;
          else if (this.isInfinite == false)
            this.timeDidReachEnd = true;
          else
            this.time = 0;
        }
        // When pingpong is enabled, the time will be capped to 0 as well. When
        // it is hit, the tween will play forwards again and didReachEnd will be
        // set to true if the tween is not infinite.
        else if (this.hasPingPong == true && this.time < 0) {
          this.time = 0;
          this.isPlayingForward = true;
          if (this.isInfinite == false)
            this.timeDidReachEnd = true;
        }
        // The time will be updated on the inheriter.
        this.OnUpdate (Easer.Apply (this.ease, this.time));
        // When the end is reached either the loop count will be decreased, or
        // the tween will be decommissioned, and the oncomplete may be invoked.
        if (this.timeDidReachEnd == true)
          if (this.hasLoopCount == true && this.loopCount > 1) {
            this.timeDidReachEnd = false;
            this.loopCount -= 1;
            this.time = 0;
          } else {
            if (this.hasOnComplete == true)
              this.onComplete ();
            this.Decommission ();
          }
      }
    }

    /// Destroys the component.
    private void Decommission () {
      this.isDecommissioned = true;
      UnityEngine.Object.Destroy (this);
    }

    // Returns the interpolated value of time between from and to.
    internal float InterpolateValue (float from, float to, float value) {
      if (this.hasOvershooting == true) {
        if (value > 1)
          value -= (value - 1) / (this.overshooting + 1);
        else if (time < 0)
          value -= value / (this.overshooting + 1);
      }
      return from * (1 - value) + to * value;
    }

    /// Sets the final values required for the tween can start. When the object
    ///  is not active in the hierarchy, it will be decommissioned right away.
    internal Tween<DriverValueType> Finalize (float duration, DriverValueType valueTo) {
      if (this.gameObject.activeInHierarchy == false)
        this.Decommission ();
      else {
        this.duration = duration;
        this.hasDuration = duration > 0;
        this.valueTo = valueTo;
      }
      return this;
    }

    /// Sets the value this tween should animate from instead of its current.
    public Tween<DriverValueType> SetFrom (DriverValueType valueFrom) {
      this.didOverwriteFrom = true;
      this.valueFrom = valueFrom;
      return this;
    }

    /// Binds an onComplete event which will be invoked when the tween ends.
    public Tween<DriverValueType> SetOnComplete (Action onComplete) {
      this.hasOnComplete = true;
      this.onComplete = onComplete;
      return this;
    }

    // Binds an onCancel event which will be invoked when the tween is canceled.
    public Tween<DriverValueType> SetOnCancel (Action onCancel) {
      this.hasOnCancel = true;
      this.onCancel = onCancel;
      return this;
    }

    /// Sets the loop type to ping pong, this will bounce the animation back
    /// and forth endlessly. When a loop count is set, the tween has play forward
    /// and backwards to count as one cycle.
    public Tween<DriverValueType> SetPingPong () {
      this.hasPingPong = true;
      return this;
    }

    /// Sets the loop count of this tween until it can be decomissioned.
    public Tween<DriverValueType> SetLoopCount (int loopCount) {
      this.hasLoopCount = true;
      this.loopCount = loopCount;
      return this;
    }

    /// Sets this tween to infinite, the loopcount will be ignored.
    public Tween<DriverValueType> SetInfinite () {
      this.isInfinite = true;
      return this;
    }

    /// Sets the delay of this tween. The tween will not play anything until
    /// the requested delay time is reached. You can change this behaviour by
    /// enabeling 'goToFirstFrameImmediately' to set the animation to the first
    /// frame immediately.
    public Tween<DriverValueType> SetDelay (float delay, bool goToFirstFrameImmediately = false) {
      this.delay = delay;
      this.hasDelay = true;
      this.goToFirstFrameImmediately = goToFirstFrameImmediately;
      return this;
    }

    /// Sets the time of the tween to a random value.
    public Tween<DriverValueType> SetRandomTime () {
      this.time = UnityEngine.Random.Range (0f, 1f);
      return this;
    }

    /// Sets the time of the tween.
    public Tween<DriverValueType> SetTime (float time) {
      this.time = time;
      return this;
    }

    /// Sets wheter the playback and delay should be paused.
    public Tween<DriverValueType> SetPaused (bool isPaused) {
      this.isPaused = isPaused;
      return this;
    }

    /// Sets wheter the tween should use Time.unscaledDeltaTime instead of Time.deltaTime.
    public Tween<DriverValueType> SetUseUnscaledTime(bool useUnscaledTime) {
        this.useUnscaledTime = useUnscaledTime;
        return this;
    }

    /// Sets the overshooting of Eases that exceed their boundaries such as
    /// elastic and back.
    public Tween<DriverValueType> SetOvershooting (float overshooting) {
      this.overshooting = overshooting;
      this.hasOvershooting = true;
      return this;
    }

    /// Sets the ease for this tween.
    public Tween<DriverValueType> SetEase (EaseType ease) {
      this.ease = ease;
      return this;
    }

    /// Sets the ease for this tween to Linear.
    public Tween<DriverValueType> SetEaseLinear () {
      this.ease = EaseType.Linear;
      return this;
    }

    /// Sets the ease for this tween to Sine In.
    public Tween<DriverValueType> SetEaseSineIn () {
      this.ease = EaseType.SineIn;
      return this;
    }

    /// Sets the ease for this tween to Sine Out.
    public Tween<DriverValueType> SetEaseSineOut () {
      this.ease = EaseType.SineOut;
      return this;
    }

    /// Sets the ease for this tween to Sine In Out.
    public Tween<DriverValueType> SetEaseSineInOut () {
      this.ease = EaseType.SineInOut;
      return this;
    }

    /// Sets the ease for this tween to Quad In.
    public Tween<DriverValueType> SetEaseQuadIn () {
      this.ease = EaseType.QuadIn;
      return this;
    }

    /// Sets the ease for this tween to Quad Out.
    public Tween<DriverValueType> SetEaseQuadOut () {
      this.ease = EaseType.QuadOut;
      return this;
    }

    /// Sets the ease for this tween to Quad In Out.
    public Tween<DriverValueType> SetEaseQuadInOut () {
      this.ease = EaseType.QuadInOut;
      return this;
    }

    /// Sets the ease for this tween to Cubic In.
    public Tween<DriverValueType> SetEaseCubicIn () {
      this.ease = EaseType.CubicIn;
      return this;
    }

    /// Sets the ease for this tween to Cubic Out.
    public Tween<DriverValueType> SetEaseCubicOut () {
      this.ease = EaseType.CubicOut;
      return this;
    }

    /// Sets the ease for this tween to Cubic In Out.
    public Tween<DriverValueType> SetEaseCubicInOut () {
      this.ease = EaseType.CubicInOut;
      return this;
    }

    /// Sets the ease for this tween to Quart In.
    public Tween<DriverValueType> SetEaseQuartIn () {
      this.ease = EaseType.QuartIn;
      return this;
    }

    /// Sets the ease for this tween to Quart Out.
    public Tween<DriverValueType> SetEaseQuartOut () {
      this.ease = EaseType.QuartOut;
      return this;
    }

    /// Sets the ease for this tween to Quart In Out.
    public Tween<DriverValueType> SetEaseQuartInOut () {
      this.ease = EaseType.QuartInOut;
      return this;
    }

    /// Sets the ease for this tween to Quint In.
    public Tween<DriverValueType> SetEaseQuintIn () {
      this.ease = EaseType.QuintIn;
      return this;
    }

    /// Sets the ease for this tween to Quint Out.
    public Tween<DriverValueType> SetEaseQuintOut () {
      this.ease = EaseType.QuintOut;
      return this;
    }

    /// Sets the ease for this tween to Quint In Out.
    public Tween<DriverValueType> SetEaseQuintInOut () {
      this.ease = EaseType.QuintInOut;
      return this;
    }

    /// Sets the ease for this tween to Expo In.
    public Tween<DriverValueType> SetEaseExpoIn () {
      this.ease = EaseType.ExpoIn;
      return this;
    }

    /// Sets the ease for this tween to Expo Out.
    public Tween<DriverValueType> SetEaseExpoOut () {
      this.ease = EaseType.ExpoOut;
      return this;
    }

    /// Sets the ease for this tween to Expo In Out.
    public Tween<DriverValueType> SetEaseExpoInOut () {
      this.ease = EaseType.ExpoInOut;
      return this;
    }

    /// Sets the ease for this tween to Circ In.
    public Tween<DriverValueType> SetEaseCircIn () {
      this.ease = EaseType.CircIn;
      return this;
    }

    /// Sets the ease for this tween to Circ Out.
    public Tween<DriverValueType> SetEaseCircOut () {
      this.ease = EaseType.CircOut;
      return this;
    }

    /// Sets the ease for this tween to Circ In Out.
    public Tween<DriverValueType> SetEaseCircInOut () {
      this.ease = EaseType.CircInOut;
      return this;
    }

    /// Sets the ease for this tween to Back In.
    public Tween<DriverValueType> SetEaseBackIn () {
      this.ease = EaseType.BackIn;
      return this;
    }

    /// Sets the ease for this tween to Back Out.
    public Tween<DriverValueType> SetEaseBackOut () {
      this.ease = EaseType.BackOut;
      return this;
    }

    /// Sets the ease for this tween to Back In Out.
    public Tween<DriverValueType> SetEaseBackInOut () {
      this.ease = EaseType.BackInOut;
      return this;
    }

    /// Sets the ease for this tween to Elastic In.
    public Tween<DriverValueType> SetEaseElasticIn () {
      this.ease = EaseType.ElasticIn;
      return this;
    }

    /// Sets the ease for this tween to Elastic Out.
    public Tween<DriverValueType> SetEaseElasticOut () {
      this.ease = EaseType.ElasticOut;
      return this;
    }

    /// Sets the ease for this tween to Elastic In Out.
    public Tween<DriverValueType> SetEaseElasticInOut () {
      this.ease = EaseType.ElasticInOut;
      return this;
    }

    /// Sets the ease for this tween to Bounce In.
    public Tween<DriverValueType> SetEaseBounceIn () {
      this.ease = EaseType.BounceIn;
      return this;
    }

    /// Sets the ease for this tween to Bounce Out.
    public Tween<DriverValueType> SetEaseBounceOut () {
      this.ease = EaseType.BounceOut;
      return this;
    }

    /// Sets the ease for this tween to Bounce In Out.
    public Tween<DriverValueType> SetEaseBounceInOut () {
      this.ease = EaseType.BounceInOut;
      return this;
    }

    /// Set the sequence delay of the tween, this is used by the sequence module
    /// and should not be used manually. The sequence delay overwrites the
    /// original delay.
    public void SetSequenceDelay (float delay) {
      this.delay = delay;
      this.hasDelay = true;
      this.goToFirstFrameImmediately = false;
    }

    /// Gets the total duration of the tween including the loop count and
    /// ping pong settings, and the delay optionally.
    public float GetTotalDuration (bool includeDelay = false) {
      var _duration = this.duration;
      if (this.hasLoopCount == true)
        _duration *= this.loopCount;
      if (this.hasPingPong == true)
        _duration *= 2f;
      if (includeDelay == true && this.hasDelay == true)
        _duration += this.delay;
      return _duration;
    }

    /// Cancel the tween and decommision the component.
    public void Cancel () {
      if (this.hasOnCancel == true)
        this.onCancel ();
      this.Decommission ();
    }

    /// Adds and returns a driver to a gameObject.
    internal static Driver Add<Driver> (GameObject gameObject) where Driver : Tween<DriverValueType> =>
      gameObject.AddComponent<Driver> ();

    /// Adds and returns a driver to a component.
    internal static Driver Add<Driver> (Component component) where Driver : Tween<DriverValueType> =>
      component.gameObject.AddComponent<Driver> ();
  }
}
