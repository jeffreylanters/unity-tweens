namespace Tweens.Core {
  public abstract class Tween<ComponentType, DataType> : Tween {
    public Nullable<DataType> from;
    public Nullable<DataType> to;
    public System.Action<TweenInstance<ComponentType, DataType>> onStart; // TODO -- make this a delegate
    public System.Action<TweenInstance<ComponentType, DataType>, DataType> onUpdate; // TODO -- make this a delegate
    public System.Action<TweenInstance<ComponentType, DataType>> onEnd; // TODO -- make this a delegate
    public System.Action onCancel; // TODO -- make this a delegate

    internal abstract DataType Current(ComponentType component);
    internal abstract DataType Lerp(DataType from, DataType to, float time);
    internal abstract void Apply(ComponentType component, DataType value);
  }
}