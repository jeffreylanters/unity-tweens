namespace Tweens.Core.Data {
  public class SetValue<Type> {
    public Type value;
    public bool IsSet { get; private set; }

    public void Unset () {
      IsSet = false;
    }

    public static implicit operator Type (SetValue<Type> test) {
      return test.value;
    }

    public static implicit operator SetValue<Type> (Type value) {
      return new SetValue<Type> { value = value, IsSet = true };
    }
  }
}