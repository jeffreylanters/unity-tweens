namespace Tweens.Core {
  public abstract class Tween {
    public float duration;
    public float? delay;
    public bool useScaledTime = true;
    public bool usePingPong;
    public bool isInfinite;
    public int? loops;
    public EaseType easeType;
    public bool prewarm;
  }
}