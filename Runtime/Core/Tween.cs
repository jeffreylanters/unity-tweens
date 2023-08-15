using System;
using UnityEngine;

namespace Tweens.Core {
  public abstract class Tween {
    public float duration;
    public float? delay;
    public float? pingPongInterval;
    public float? repeatInterval;
    public bool useScaledTime = true;
    public bool usePingPong;
    public bool isInfinite;
    public int? loops;
    public EaseType easeType;
    public FillMode fillMode = FillMode.Backwards;
  }

  public abstract class Tween<ComponentType, DataType> : Tween where ComponentType : Component {
    public Nullable<DataType> from;
    public Nullable<DataType> to;
    public Action<TweenInstance<ComponentType, DataType>> onStart; // TODO -- make this a delegate
    public Action<TweenInstance<ComponentType, DataType>, DataType> onUpdate; // TODO -- make this a delegate
    public Action<TweenInstance<ComponentType, DataType>> onEnd; // TODO -- make this a delegate
    public Action onCancel; // TODO -- make this a delegate

    internal abstract DataType Current(ComponentType component);
    internal abstract DataType Lerp(DataType from, DataType to, float time);
    internal abstract void Apply(ComponentType component, DataType value);
  }
}