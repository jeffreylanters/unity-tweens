namespace Tweens.Core.Data {
  public class CompletableValue<Type> {
    public Type value;
    public bool IsSet { get; private set; }
    public bool DidComplete { get; private set; }

    public void Unset() {
      IsSet = false;
    }

    public void Complete() {
      DidComplete = true;
    }

    public static implicit operator Type(CompletableValue<Type> test) {
      return test.value;
    }

    public static implicit operator CompletableValue<Type>(Type value) {
      return new CompletableValue<Type> { value = value, IsSet = true };
    }
  }
}