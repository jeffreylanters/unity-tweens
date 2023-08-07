namespace Tweens.Core.Data {
  public class SetValue<Type> {
    public Type Value { get; private set; }
    internal bool HasValue { get; private set; }

    internal SetValue() { }

    internal SetValue(Type value) {
      Value = value;
      HasValue = true;
    }

    internal SetValue(SetValue<Type> setValue) {
      Value = setValue.Value;
      HasValue = setValue.HasValue;
    }

    internal void Unset() {
      HasValue = false;
    }

    public static implicit operator Type(SetValue<Type> test) {
      return test.Value;
    }

    public static implicit operator SetValue<Type>(Type value) {
      return new SetValue<Type> { Value = value, HasValue = true };
    }
  }
}