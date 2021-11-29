using System;
using UnityEngine;
using System.Threading;
using System.Collections;
using System.Threading.Tasks;

namespace ElRaccoone.Tweens.Core {

  /// <summary>
  /// Base class for all Tweens with a value type for the driver and a component.
  /// </summary>
  /// <typeparam name="DriverValueType">The type of the Tweened value.</typeparam>
  /// <typeparam name="ComponentType">The type of the target Component.</typeparam>
  public abstract class Tween<DriverValueType, ComponentType> : Tween<DriverValueType> where ComponentType : Component {

    /// <summary>
    /// A reference to the target componented fetched during the on initialize.
    /// </summary>
    internal ComponentType component { get; private set; }

    /// <summary>
    /// During the on initialize cycle the target component will be fetched.
    /// </summary>
    /// <returns>Wether the component was available.</returns>
    public override bool OnInitialize () {
      this.component = this.gameObject.GetComponent<ComponentType> ();
      return this.component != null;
    }
  }

  /// <summary>
  /// Base class for all Tweens with a value type for the driver.
  /// </summary>
  public abstract class Tween<DriverValueType> : MonoBehaviour, ITween {

    /// <summary>
    /// The value the driver should Tween from.
    /// </summary>
    internal DriverValueType valueFrom = default;

    /// <summary>
    /// The value the driver should Tween to.
    /// </summary>
    internal DriverValueType valueTo = default;

    /// <summary>
    /// The state value the driving is currently tweening at.
    /// </summary>
    internal DriverValueType valueCurrent = default;

    /// <summary>
    /// Defines whether the Tween is paused.
    /// </summary>
    private bool isPaused = false;

    /// <summary>
    /// The current play-time of the Tween. When actually playing, this value
    /// is increased every frame based on a number of factors such as the
    /// duration and the use of unscaled timing.
    /// </summary>
    private float time = 0;

    /// <summary>
    /// The Eas type of the Tween defining the style of animation.
    /// </summary>
    private EaseType ease = 0;

    /// <summary>
    /// Defines whether the Tween is decommissioned, when set to true the Tween
    /// will be stopped and destroyed as soon as possible. All playback will stop.
    /// </summary>
    private bool isDecommissioned = false;

    /// <summary>
    /// Defines whether the Tween should play infinitly.
    /// </summary>
    private bool isInfinite = false;

    /// <summary>
    /// Defines whether the from value has been overwritten. If not, the initial
    /// value will be used to free from. This is defined by the Driver.
    /// </summary>
    private bool didOverwriteFrom = false;

    /// <summary>
    /// Defines whether the Tween uses ping pong during it's animation. When set
    /// to true, the twee will play back and forth. Going once forth and once
    /// back counts as one cycle.
    /// </summary>
    private bool hasPingPong = false;

    /// <summary>
    /// Defines whether the Tween is playing forward, this is only used for the
    /// ping pong mechanic.
    /// </summary>
    private bool isPlayingForward = true;

    /// <summary>
    /// Defines whether the Tween did reach the end time. If true, and no other
    /// values such as ping pong or infinite will overwrite it, the Tween will
    /// be decommissioned.
    /// </summary>
    private bool didTimeReachEnd = false;

    /// <summary>
    /// Defines whether the Tween should use the unscale time, if false, scaled
    /// time will be used by default.
    /// </summary>
    private bool useUnscaledTime = false;

    /// <summary>
    /// Defines whether the Tween has a loop count, if true the Tween will keep
    /// re-playing until the loop count hits zero. When ping pong is enbaled,
    /// a play forth and back counts as a single loop.
    /// </summary>
    private bool hasLoopCount = false;

    /// <summary>
    /// The value of the loop count. When the loop count is used the Tween will 
    /// keep re-playing until the loop count hits zero. When ping pong is enbaled,
    /// a play forth and back counts as a single loop.
    /// </summary>
    private int loopCount = 0;

    /// <summary>
    /// Defines whether the Tween has a duration, we could assume this is true
    /// but in theory a developer could append a tween manually without setting
    /// the Tween's duration.
    /// </summary>
    private bool hasDuration = false;

    /// <summary>
    /// The duration of the Tween, it's value is used to calculate the
    /// progression of the time each frame.
    /// </summary>
    private float duration = 0;

    /// <summary>
    /// Defines whether the Tween has a delay, the delay will hold the Tween
    /// for its first play for a given amount of time.
    /// </summary>
    private bool hasDelay = false;

    /// <summary>
    /// The delay of the Tween, when defines this will hold the Tween for its
    /// first play. Any play after that when looping or ping-ponging will not
    /// be delayed.
    /// </summary>
    private float delay = 0;

    /// <summary>
    /// By default the value Tween will jump to the first frame of the animation
    /// when the Tween is actually starting after its delay. Changing this value
    /// will change this behaviour, when enabled the Tween will jump to the first
    /// frame right away while still waiting for the delay.
    /// </summary>
    private bool goToFirstFrameImmediately = false;

    /// <summary>
    /// Defines whether the Tween has an overshooting multiplier. When this is
    /// enabled, easing types such as Back will multiply their strength when
    /// their times goes out of bounds.
    /// </summary>
    private bool hasOvershooting = false;

    /// <summary>
    /// The overshooting multiplier is used on Tweens with easing types such as
    /// Back will multiply their strength when their times goes out of bounds.
    /// </summary>
    private float overshooting = 0;

    /// <summary>
    /// Defines whether this Tween has a completion callback. When this is
    /// defined, the onComplete action will be invoked when the Tween completes.
    /// </summary>
    private bool hasOnComplete = false;

    /// <summary>
    /// The completion callback will be invoked when the Tween completes. This
    /// will only happen when the Tween truely ends and will not invoke when
    /// the Tween is canceld or destroyed.
    /// </summary>
    private Action onComplete = null;

    /// <summary>
    /// Defines whether this Tween has a cancelation callback. When this is
    /// defined, the onCancel action will be invoked when the Tween cancels.
    /// </summary>
    private bool hasOnCancel = false;

    /// <summary>
    /// The cancelation callback will be invoked when the Tween is canceled.
    /// This will only happen when the Tween is manually canceled and will not
    /// invoke when the Tween is decommissioned due to a destroy or missing
    /// component reference.
    /// </summary>
    private Action onCancel = null;

    /// <summary>
    /// Defines whether the Tween is completed, this flag will only be set to
    /// true when the Tween is truely over and did all of its animation cycles.
    /// </summary>
    private bool isCompleted = false;

    /// <summary>
    /// On Initialize will be invoked when the Tween will initialize. During this 
    /// cycle the Tween has yet to be started, but expect all chainable options 
    /// to be set already. This method should return a boolean informing the 
    /// Tween if the initialization was successfull. When it was not, the Tween 
    /// will be decommissioned.
    /// </summary>
    /// <returns>Whether the Tween is initialized succesfully.</returns>
    public abstract bool OnInitialize ();

    /// <summary>
    /// On Get From will be invoked when the Tween wants to fetch its from value.
    /// When the Tween was initialized with a SetFrom chainable option, this will
    /// not be invoked.
    /// </summary>
    /// <returns>The new From value.</returns>
    public abstract DriverValueType OnGetFrom ();

    /// <summary>
    /// On Update will be invoked every frame and passes the eased time. During
    /// this cycle all animation calculations can be performed.
    /// </summary>
    /// <param name="easedTime">The current time of the ease.</param>
    public abstract void OnUpdate (float easedTime);

    /// <summary>
    /// During the monobehaviour start cycle, initialization will be performed.
    /// </summary>
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

    /// <summary>
    /// When the object is disabled, but the tween did not finish, we will
    /// decommission it.
    /// </summary>
    private void OnDisable () {
      if (this.didTimeReachEnd == false)
        this.Decommission ();
    }

    /// <summary>
    /// During the monobehaviour update cycle, the logic will be performed.
    /// </summary>
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
      // animation will be set to its last frame, the Tween will be 
      // decomissioned right away.
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
            this.didTimeReachEnd = true;
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
            this.didTimeReachEnd = true;
        }
        // The time will be updated on the inheriter.
        this.OnUpdate (Easer.Apply (this.ease, this.time));
        // When the end is reached either the loop count will be decreased, or
        // the tween will be marked as completed and will be decommissioned, 
        // the oncomplete may be invoked.
        if (this.didTimeReachEnd == true)
          if (this.hasLoopCount == true && this.loopCount > 1) {
            this.didTimeReachEnd = false;
            this.loopCount -= 1;
            this.time = 0;
          } else {
            if (this.hasOnComplete == true)
              this.onComplete ();
            this.isCompleted = true;
            this.Decommission ();
          }
      }
    }

    /// <summary>
    /// Destroys the component.
    /// </summary>
    private void Decommission () {
      this.isDecommissioned = true;
      UnityEngine.Object.Destroy (this);
    }

    /// <summary>
    /// Returns the interpolated value of time between from and to.
    /// </summary>
    /// <param name="from">The value to interpolate from.</param>
    /// <param name="to">The value to interpolate to.</param>
    /// <param name="time">The time of the interpolation.</param>
    /// <returns>The interpolated value.</returns>
    internal float InterpolateValue (float from, float to, float time) {
      if (this.hasOvershooting == true) {
        if (time > 1)
          time -= (time - 1) / (this.overshooting + 1);
        else if (this.time < 0)
          time -= time / (this.overshooting + 1);
      }
      return from * (1 - time) + to * time;
    }

    /// <summary>
    /// Sets the final values required for the tween can start. When the object
    /// is not active in the hierarchy, the Tween will be decommissioned right 
    /// away.
    /// </summary>
    /// <param name="duration">The duration of the tween.</param>
    /// <param name="valueTo">The To value.</param>
    /// <returns>The current Tween.</returns>
    internal Tween<DriverValueType> Finalize (DriverValueType valueTo, float duration) {
      if (this.gameObject.activeInHierarchy == false) {
        this.Decommission ();
      } else {
        this.duration = duration;
        this.hasDuration = duration > 0;
        this.valueTo = valueTo;
      }
      return this;
    }

    /// <summary>
    /// Sets the value this tween should animate from instead of its current.
    /// </summary>
    /// <param name="valueFrom">The from value.</param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetFrom (DriverValueType valueFrom) {
      this.didOverwriteFrom = true;
      this.valueFrom = valueFrom;
      return this;
    }

    /// <summary>
    /// Binds an onComplete event which will be invoked when the tween ends.
    /// </summary>
    /// <param name="onComplete">The completion callback.</param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetOnComplete (Action onComplete) {
      this.hasOnComplete = true;
      this.onComplete = onComplete;
      return this;
    }

    /// <summary>
    /// Binds an onCancel event which will be invoked when the tween is canceled.
    /// </summary>
    /// <param name="onCancel">The cancelation callback.</param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetOnCancel (Action onCancel) {
      this.hasOnCancel = true;
      this.onCancel = onCancel;
      return this;
    }

    /// <summary>
    /// Sets the loop type to ping pong, this will bounce the animation back
    /// and forth endlessly. When a loop count is set, the tween has play forward
    /// and backwards to count as one cycle.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetPingPong () {
      this.hasPingPong = true;
      return this;
    }

    /// <summary>
    /// Sets the loop count of this tween until it can be decomissioned.
    /// </summary>
    /// <param name="loopCount">The target number of loops.</param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetLoopCount (int loopCount) {
      this.hasLoopCount = true;
      this.loopCount = loopCount;
      return this;
    }

    /// <summary>
    /// Sets this tween to infinite, the loopcount will be ignored.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetInfinite () {
      this.isInfinite = true;
      return this;
    }

    /// <summary>
    /// Sets the delay of this tween. The tween will not play anything until
    /// the requested delay time is reached. You can change this behaviour by
    /// enabeling 'goToFirstFrameImmediately' to set the animation to the first
    /// frame immediately.
    /// </summary>
    /// <param name="delay">The delay.</param>
    /// <param name="goToFirstFrameImmediately">Go to the first frame immediately</param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetDelay (float delay, bool goToFirstFrameImmediately = false) {
      this.delay = delay;
      this.hasDelay = true;
      this.goToFirstFrameImmediately = goToFirstFrameImmediately;
      return this;
    }

    /// <summary>
    /// Sets the time of the tween to a random value.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetRandomTime () {
      this.time = UnityEngine.Random.Range (0f, 1f);
      return this;
    }

    /// <summary>
    /// Sets the time of the tween.
    /// </summary>
    /// <param name="time"></param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetTime (float time) {
      this.time = time;
      return this;
    }

    /// <summary>
    /// Sets wheter the playback and delay should be paused.
    /// </summary>
    /// <param name="isPaused"></param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetPaused (bool isPaused) {
      this.isPaused = isPaused;
      return this;
    }

    /// <summary>
    /// Sets wheter the tween should use Time.unscaledDeltaTime instead of Time.deltaTime.
    /// </summary>
    /// <param name="useUnscaledTime">Use unscaled time.</param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetUseUnscaledTime (bool useUnscaledTime) {
      this.useUnscaledTime = useUnscaledTime;
      return this;
    }

    /// <summary>
    /// Sets the overshooting of Eases that exceed their boundaries such as
    /// elastic and back.
    /// </summary>
    /// <param name="overshooting">The overshooting value.</param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetOvershooting (float overshooting) {
      this.overshooting = overshooting;
      this.hasOvershooting = true;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween.
    /// </summary>
    /// <param name="ease">The target ease type.</param>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEase (EaseType ease) {
      this.ease = ease;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Linear.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseLinear () {
      this.ease = EaseType.Linear;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Sine In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseSineIn () {
      this.ease = EaseType.SineIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Sine Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseSineOut () {
      this.ease = EaseType.SineOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Sine In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseSineInOut () {
      this.ease = EaseType.SineInOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Quad In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseQuadIn () {
      this.ease = EaseType.QuadIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Quad Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseQuadOut () {
      this.ease = EaseType.QuadOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Quad In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseQuadInOut () {
      this.ease = EaseType.QuadInOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Cubic In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseCubicIn () {
      this.ease = EaseType.CubicIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Cubic Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseCubicOut () {
      this.ease = EaseType.CubicOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Cubic In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseCubicInOut () {
      this.ease = EaseType.CubicInOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Quart In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseQuartIn () {
      this.ease = EaseType.QuartIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Quart Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseQuartOut () {
      this.ease = EaseType.QuartOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Quart In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseQuartInOut () {
      this.ease = EaseType.QuartInOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Quint In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseQuintIn () {
      this.ease = EaseType.QuintIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Quint Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseQuintOut () {
      this.ease = EaseType.QuintOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Quint In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseQuintInOut () {
      this.ease = EaseType.QuintInOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Expo In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseExpoIn () {
      this.ease = EaseType.ExpoIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Expo Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseExpoOut () {
      this.ease = EaseType.ExpoOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Expo In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseExpoInOut () {
      this.ease = EaseType.ExpoInOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Circ In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseCircIn () {
      this.ease = EaseType.CircIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Circ Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseCircOut () {
      this.ease = EaseType.CircOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Circ In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseCircInOut () {
      this.ease = EaseType.CircInOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Back In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseBackIn () {
      this.ease = EaseType.BackIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Back Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseBackOut () {
      this.ease = EaseType.BackOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Back In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseBackInOut () {
      this.ease = EaseType.BackInOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Elastic In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseElasticIn () {
      this.ease = EaseType.ElasticIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Elastic Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseElasticOut () {
      this.ease = EaseType.ElasticOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Elastic In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseElasticInOut () {
      this.ease = EaseType.ElasticInOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Bounce In.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseBounceIn () {
      this.ease = EaseType.BounceIn;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Bounce Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseBounceOut () {
      this.ease = EaseType.BounceOut;
      return this;
    }

    /// <summary>
    /// Sets the ease for this tween to Bounce In Out.
    /// </summary>
    /// <returns>The current Tween.</returns>
    public Tween<DriverValueType> SetEaseBounceInOut () {
      this.ease = EaseType.BounceInOut;
      return this;
    }

    /// <summary>
    /// Gets the total duration of the tween including the loop count and
    /// ping pong settings, and the delay optionally.
    /// </summary>
    /// <param name="includeDelay">Include delay in calculation?</param>
    /// <returns>The total duration of the Tween.</returns>
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

    /// <summary>
    /// Cancel the tween and decommision the component.
    /// </summary>
    public void Cancel () {
      if (this.hasOnCancel == true)
        this.onCancel ();
      this.Decommission ();
    }

    /// <summary>
    /// Returns a Task which awaits the Tween's completion or decommissioning.
    /// </summary>
    /// <returns>An awaitable Task.</returns>
    public async Task Await () {
      while (this.isCompleted == false && this.isDecommissioned == false) {
#if UNITY_EDITOR
        // It is possible for the Application to stop playing in the middle of a
        // Tween. Usually this is no problem, since the application is stopped
        // anyway. But when in the editor, the runtime is still running, so to
        // avoid any issues, we stop when the application is no longer playing.
        if (Application.isPlaying == false)
          return;
#endif
        await Task.Yield ();
      }
    }

    /// <summary>
    /// Returns an enumerator which yields the Tween's completion or decommissioning.
    /// </summary>
    /// <returns>An enumerator.</returns>
    public IEnumerator Yield () {
      while (this.isCompleted == false && this.isDecommissioned == false)
        yield return 0;
    }

    /// <summary>
    /// Adds a Tween Driver.
    /// </summary>
    /// <typeparam name="Driver">The type of the Driver.</typeparam>
    /// <param name="gameObject">The target Game Object.</param>
    /// <returns>The instanciated Driver.</returns>
    internal static Driver Add<Driver> (GameObject gameObject) where Driver : Tween<DriverValueType> =>
      gameObject.AddComponent<Driver> ();

    /// <summary>
    /// Adds a Tween Driver.
    /// </summary>
    /// <typeparam name="Driver">The type of the Driver.</typeparam>
    /// <param name="component">The target Component.</param>
    /// <returns>The instanciated Driver.</returns>
    internal static Driver Add<Driver> (Component component) where Driver : Tween<DriverValueType> =>
      component.gameObject.AddComponent<Driver> ();
  }
}
