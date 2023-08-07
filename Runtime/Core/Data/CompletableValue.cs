namespace Tweens.Core.Data {
  public class CompletableValue<Type> {
    public Type Value { get; private set; }
    internal bool HasValue { get; private set; }
    internal bool DidComplete { get; private set; }

    internal CompletableValue() { }

    internal CompletableValue(Type value) {
      Value = value;
      HasValue = true;
    }

    internal CompletableValue(CompletableValue<Type> completableValue) {
      Value = completableValue.Value;
      HasValue = completableValue.HasValue;
    }

    internal CompletableValue(SetValue<Type> setValue) {
      Value = setValue.Value;
      HasValue = setValue.HasValue;
    }

    internal void Unset() {
      HasValue = false;
    }

    internal void Complete() {
      DidComplete = true;
    }

    public static implicit operator Type(CompletableValue<Type> test) {
      return test.Value;
    }

    public static implicit operator CompletableValue<Type>(Type value) {
      return new CompletableValue<Type> { Value = value, HasValue = true };
    }
  }
}