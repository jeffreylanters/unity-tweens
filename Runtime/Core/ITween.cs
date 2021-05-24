namespace ElRaccoone.Tweens.Core {

  /// <summary>
  /// Typeless interface for all core Tween functionality.
  /// </summary>
  public interface ITween {

    /// <summary>
    /// Gets the total duration of the tween including the loop count and
    /// ping pong settings, and the delay optionally.
    /// </summary>
    /// <param name="includeDelay">Include delay in calculation?</param>
    /// <returns>The total duration of the Tween.</returns>
    float GetTotalDuration (bool includeDelay = false);

    /// <summary>
    /// Cancel the tween and decommision the component.
    /// </summary>
    void Cancel ();
  }
}