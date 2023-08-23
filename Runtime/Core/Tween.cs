using UnityEngine;

namespace Tweens.Core {
  public abstract class Tween {
    public float duration;
    public float? delay;
    public float? pingPongInterval;
    public float? repeatInterval;
    public bool useUnscaledTime;
    public bool usePingPong;
    public bool isInfinite;
    public int? loops;
    public EaseType easeType;
    public FillMode fillMode = FillMode.Backwards;
  }

  public abstract class Tween<ComponentType, DataType> : Tween where ComponentType : Component {
    public Nullable<DataType> from;
    public Nullable<DataType> to;
    public OnStartDelegate<ComponentType, DataType> onStart;
    public OnUpdateDelegate<ComponentType, DataType> onUpdate;
    public OnEndDelegate<ComponentType, DataType> onEnd;
    public OnCancelDelegate onCancel;

    internal abstract DataType Current(ComponentType component);
    internal abstract DataType Lerp(DataType from, DataType to, float time);
    internal abstract void Apply(ComponentType component, DataType value);
  }
}