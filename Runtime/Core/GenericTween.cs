using System;
using Tweens.Core.Data;
using UnityEngine;

namespace Tweens.Core {
  public abstract class Tween<ComponentType, DataType> : Tween {
    public SetValue<DataType> from = new();
    public SetValue<Action<DataType>> onUpdate = new();
    public DataType to;
    public ComponentType component;

    internal abstract DataType From();
    internal abstract DataType Lerp(float time);
    internal abstract void Apply(DataType value);

    public Tween(GameObject target) : base(target) {
      component = target.GetComponent<ComponentType>();
    }

    internal sealed override void Awake() {
      base.Awake();
      if (!from.IsSet) {
        from.value = From();
      }
    }

    internal sealed override void Update() {
      base.Update();
      var easedTime = Easer.Apply(easeType, time);
      var value = Lerp(easedTime);
      Apply(value);
      if (onUpdate.IsSet) {
        onUpdate.value.Invoke(value);
      }
    }
  }
}