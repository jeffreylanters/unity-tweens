namespace Tweens.Core.Data {
  public class SetValue<Type> {
    public Type Value { get; private set; }
    internal bool IsSet { get; private set; }

    internal SetValue() { }

    internal SetValue(Type value) {
      this.Value = value;
      IsSet = true;
    }

    internal SetValue(SetValue<Type> setValue) {
      Value = setValue.Value;
      IsSet = setValue.IsSet;
    }

    internal void Unset() {
      IsSet = false;
    }

    public static implicit operator Type(SetValue<Type> test) {
      return test.Value;
    }

    public static implicit operator SetValue<Type>(Type value) {
      return new SetValue<Type> { Value = value, IsSet = true };
    }
  }
}