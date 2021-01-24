namespace ElRaccoone.Tweens.Core {

  /// Typeless interface for all core Tween functionality.
  public interface ITween {

    /// Set the sequence delay of the tween, this is used by the sequence module
    /// and should not be used manually. The sequence delay overwrites the
    /// original delay.
    void SetSequenceDelay (float delay);

    /// Returns the total duration of the tween including the loop count and
    /// ping pong settings, and the delay optionally.
    float GetTotalDuration (bool includeDelay = false);

    /// Cancel the tween and decommision the component.
    void Cancel ();
  }
}