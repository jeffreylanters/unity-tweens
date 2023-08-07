using Tweens.Core.Data;

namespace Tweens.Core {
  public abstract class Tween {
    public float duration;
    public SetValue<float> delay = new();
    public bool useScaledTime = true;
    public bool usePingPong;
    public bool prewarm;
    public bool isInfinite;
    public SetValue<int> loops = new();
    public EaseType easeType;
  }
}