namespace ElRaccoone.Tweens.Core {

  /// The ease type defines the type of the Ease that will be used during the
  /// animation. The ease type can be changed using SetTween or one of the
  /// SetTween... methods.
  /// TODO move this file to another namespace?
  public enum EaseType {

    /// The tween will ease using a linear motion.
    Linear = 0,

    /// The tween will ease using a sine in motion.
    SineIn = 10,

    /// The tween will ease using a sine out motion.
    SineOut = 11,

    /// The tween will ease using a sine in out motion.
    SineInOut = 12,

    /// The tween will ease using a quad in motion.
    QuadIn = 20,

    /// The tween will ease using a quad out motion.
    QuadOut = 21,

    /// The tween will ease using a quad in out motion.
    QuadInOut = 22,

    /// The tween will ease using a cubic in motion.
    CubicIn = 30,

    /// The tween will ease using a cubic out motion.
    CubicOut = 31,

    /// The tween will ease using a cubic in out motion.
    CubicInOut = 32,

    /// The tween will ease using a quart in motion.
    QuartIn = 40,

    /// The tween will ease using a quart out motion.
    QuartOut = 41,

    /// The tween will ease using a quart in out motion.
    QuartInOut = 42,

    /// The tween will ease using a quint in motion.
    QuintIn = 50,

    /// The tween will ease using a quint out motion.
    QuintOut = 51,

    /// The tween will ease using a quint in out motion.
    QuintInOut = 52,

    /// The tween will ease using a expo in motion.
    ExpoIn = 60,

    /// The tween will ease using a expo out motion.
    ExpoOut = 61,

    /// The tween will ease using a expo in out motion.
    ExpoInOut = 62,

    /// The tween will ease using a circ in motion.
    CircIn = 70,

    /// The tween will ease using a circ out motion.
    CircOut = 71,

    /// The tween will ease using a circ in out motion.
    CircInOut = 72,

    /// The tween will ease using a back in motion.
    BackIn = 80,

    /// The tween will ease using a back out motion.
    BackOut = 81,

    /// The tween will ease using a back in out motion.
    BackInOut = 82,

    /// The tween will ease using a elastic in motion.
    ElasticIn = 90,

    /// The tween will ease using a elastic out motion.
    ElasticOut = 91,

    /// The tween will ease using a elastic in out motion.
    ElasticInOut = 92,

    /// The tween will ease using a bounce in motion.
    BounceIn = 100,

    /// The tween will ease using a bounce out motion.
    BounceOut = 101,

    /// The tween will ease using a bounce in out motion.
    BounceInOut = 102,
  }
}