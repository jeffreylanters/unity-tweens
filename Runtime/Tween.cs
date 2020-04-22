using System;
using UnityEngine;

namespace UnityPackages.Tweens {
  public abstract class Tween<T> : MonoBehaviour {

    [HideInInspector] public T valueTo = default (T);
    [HideInInspector] public T valueFrom = default (T);
    [HideInInspector] public T valueCurrent = default (T);

    private float time = 0;
    private float duration = 0;
    private Ease ease = 0;
    private bool isCompleted = false;
    private bool didOverwriteFrom = false;

    public abstract T OnGetFrom ();
    public abstract void OnUpdate (float easedTime, bool isCompleted);

    private void Awake () {
      if (this.didOverwriteFrom == false)
        this.valueFrom = this.OnGetFrom ();
    }

    private void Update () {
      this.time += Time.deltaTime / this.duration;
      if (this.time >= 1)
        this.time = 1;
      this.isCompleted = this.time == 1;
      this.OnUpdate (EasingMethods.ByEase (this.ease, this.time), this.isCompleted);
      if (this.isCompleted == true)
        UnityEngine.Object.Destroy (this);
    }

    public float LerpValue (float from, float to, float time) {
      return Mathf.Lerp (from, to, time);
    }

    public Tween<T> Finalize (float duration, T valueTo) {
      this.duration = duration;
      this.valueTo = valueTo;
      return this;
    }

    public Tween<T> SetFrom (T valueFrom) {
      this.didOverwriteFrom = true;
      this.valueFrom = valueFrom;
      return this;
    }

    public Tween<T> SetEaseLinear () {
      this.ease = Ease.Linear;
      return this;
    }

    public Tween<T> SetEaseSineIn () {
      this.ease = Ease.SineIn;
      return this;
    }

    public Tween<T> SetEaseSineOut () {
      this.ease = Ease.SineOut;
      return this;
    }

    public Tween<T> SetEaseSineInOut () {
      this.ease = Ease.SineInOut;
      return this;
    }

    public Tween<T> SetEaseBackIn () {
      this.ease = Ease.BackIn;
      return this;
    }
  }
}