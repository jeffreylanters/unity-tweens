namespace ElRaccoone.Tweens.Core {

  /// <summary>
  /// The ease type defines the type of the Ease that will be used during the
  /// animation. The ease type can be changed using SetTween or one of the
  /// SetTween... methods.
  /// </summary>
  public enum EaseType {

    /// <summary>
    /// The tween will ease using a linear motion.
    /// </summary>
    Linear = 0,

    /// <summary>
    /// The tween will ease using a sine in motion.
    /// </summary>
    SineIn = 10,

    /// <summary>
    /// The tween will ease using a sine out motion.
    /// </summary>
    SineOut = 11,

    /// <summary>
    /// The tween will ease using a sine in out motion.
    /// </summary>
    SineInOut = 12,

    /// <summary>
    /// The tween will ease using a quad in motion.
    /// </summary>
    QuadIn = 20,

    /// <summary>
    /// The tween will ease using a quad out motion.
    /// </summary>
    QuadOut = 21,

    /// <summary>
    /// The tween will ease using a quad in out motion.
    /// </summary>
    QuadInOut = 22,

    /// <summary>
    /// The tween will ease using a cubic in motion.
    /// </summary>
    CubicIn = 30,

    /// <summary>
    /// The tween will ease using a cubic out motion.
    /// </summary>
    CubicOut = 31,

    /// <summary>
    /// The tween will ease using a cubic in out motion.
    /// </summary>
    CubicInOut = 32,

    /// <summary>
    /// The tween will ease using a quart in motion.
    /// </summary>
    QuartIn = 40,

    /// <summary>
    /// The tween will ease using a quart out motion.
    /// </summary>
    QuartOut = 41,

    /// <summary>
    /// The tween will ease using a quart in out motion.
    /// </summary>
    QuartInOut = 42,

    /// <summary>
    /// The tween will ease using a quint in motion.
    /// </summary>
    QuintIn = 50,

    /// <summary>
    /// The tween will ease using a quint out motion.
    /// </summary>
    QuintOut = 51,

    /// <summary>
    /// The tween will ease using a quint in out motion.
    /// </summary>
    QuintInOut = 52,

    /// <summary>
    /// The tween will ease using a expo in motion.
    /// </summary>
    ExpoIn = 60,

    /// <summary>
    /// The tween will ease using a expo out motion.
    /// </summary>
    ExpoOut = 61,

    /// <summary>
    /// The tween will ease using a expo in out motion.
    /// </summary>
    ExpoInOut = 62,

    /// <summary>
    /// The tween will ease using a circ in motion.
    /// </summary>
    CircIn = 70,

    /// <summary>
    /// The tween will ease using a circ out motion.
    /// </summary>
    CircOut = 71,

    /// <summary>
    /// The tween will ease using a circ in out motion.
    /// </summary>
    CircInOut = 72,

    /// <summary>
    /// The tween will ease using a back in motion.
    /// </summary>
    BackIn = 80,

    /// <summary>
    /// The tween will ease using a back out motion.
    /// </summary>
    BackOut = 81,

    /// <summary>
    /// The tween will ease using a back in out motion.
    /// </summary>
    BackInOut = 82,

    /// <summary>
    /// The tween will ease using a elastic in motion.
    /// </summary>
    ElasticIn = 90,

    /// <summary>
    /// The tween will ease using a elastic out motion.
    /// </summary>
    ElasticOut = 91,

    /// <summary>
    /// The tween will ease using a elastic in out motion.
    /// </summary>
    ElasticInOut = 92,

    /// <summary>
    /// The tween will ease using a bounce in motion.
    /// </summary>
    BounceIn = 100,

    /// <summary>
    /// The tween will ease using a bounce out motion.
    /// </summary>
    BounceOut = 101,

    /// <summary>
    /// The tween will ease using a bounce in out motion.
    /// </summary>
    BounceInOut = 102,
  }
}