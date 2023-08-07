namespace Tweens.Core.Data {
  public class CompletableValue<Type> {
    public Type Value { get; private set; }
    internal bool IsSet { get; private set; }
    internal bool DidComplete { get; private set; }

    internal CompletableValue() { }

    internal CompletableValue(Type value) {
      this.Value = value;
      IsSet = true;
    }

    internal CompletableValue(CompletableValue<Type> completableValue) {
      Value = completableValue.Value;
      IsSet = completableValue.IsSet;
    }

    internal CompletableValue(SetValue<Type> setValue) {
      Value = setValue.Value;
      IsSet = setValue.IsSet;
    }

    internal void Unset() {
      IsSet = false;
    }

    internal void Complete() {
      DidComplete = true;
    }

    public static implicit operator Type(CompletableValue<Type> test) {
      return test.Value;
    }

    public static implicit operator CompletableValue<Type>(Type value) {
      return new CompletableValue<Type> { Value = value, IsSet = true };
    }
  }
}