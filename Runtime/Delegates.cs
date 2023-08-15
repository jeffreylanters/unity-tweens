using UnityEngine;

namespace Tweens {
  public delegate DataType LerpDelegate<DataType>(DataType from, DataType to, float time);
  public delegate void ApplyDelegate<ComponentType, DataType>(ComponentType component, DataType value);
  public delegate float EaseFunctionDelegate(float time);
  public delegate void OnUpdateDelegate<ComponentType, DataType>(TweenInstance<ComponentType, DataType> instance, DataType value) where ComponentType : Component;
  public delegate void OnStartDelegate<ComponentType, DataType>(TweenInstance<ComponentType, DataType> instance) where ComponentType : Component;
  public delegate void OnEndDelegate<ComponentType, DataType>(TweenInstance<ComponentType, DataType> instance) where ComponentType : Component;
  public delegate void OnCancelDelegate();
}