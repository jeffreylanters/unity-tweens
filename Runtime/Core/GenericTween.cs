using System;
using Tweens.Core.Data;

namespace Tweens.Core {
  public abstract class Tween<ComponentType, DataType> : Tween {
    public SetValue<DataType> from = new();
    public SetValue<Action<TweenInstance<ComponentType, DataType>>> onStart = new();
    public SetValue<Action<TweenInstance<ComponentType, DataType>>> onCancel = new();
    public SetValue<Action<TweenInstance<ComponentType, DataType>>> onEnd = new();
    public SetValue<Action<TweenInstance<ComponentType, DataType>, DataType>> onUpdate = new();
    public DataType to;

    internal abstract DataType From(ComponentType component);
    internal abstract DataType Lerp(DataType from, DataType to, float time);
    internal abstract void Apply(ComponentType component, DataType value);
  }
}