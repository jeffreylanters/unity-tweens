using System;
using Tweens.Core.Data;
using UnityEngine;

namespace Tweens.Core {
  public abstract class Tween<Type> : Tween {
    public SetValue<Type> from = new ();
    public SetValue<Action<Type>> onUpdate = new ();
    public Type to;

    internal abstract Type From ();
    internal abstract Type Lerp (float time);
    internal abstract void Apply (Type value);

    public Tween (Component target) : base (target) { }

    internal sealed override void Awake () {
      base.Awake ();
      if (!from.IsSet) {
        from.value = From ();
      }
    }

    internal sealed override void Update () {
      base.Update ();
      var easedTime = Easer.Apply (easeType, time);
      var value = Lerp (easedTime);
      Apply (value);
      if (onUpdate.IsSet) {
        onUpdate.value.Invoke (value);
      }
    }
  }
}