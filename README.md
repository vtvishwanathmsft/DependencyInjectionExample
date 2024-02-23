Dependency Injection (DI) is a design pattern that allows for the decoupling of dependencies between objects. It is a form of Inversion of Control, where the control of creating and managing dependencies is inverted from the dependent object to an external entity, such as a DI container.

In C#, DI can be implemented using constructor injection, property injection, or method injection. In constructor injection, dependencies are passed to the dependent object through its constructor. In property injection, dependencies are set through public properties of the dependent object. In method injection, dependencies are passed as parameters to a method of the dependent object.

Here is an example of constructor injection in C#:

```csharp
public class MyClass
{
    private readonly IMyDependency _myDependency;

    public MyClass(IMyDependency myDependency)
    {
        _myDependency = myDependency;
    }

    public void MyMethod()
    {
        // Use _myDependency here
    }
}
```

In this example, `MyClass` has a dependency on `IMyDependency`, which is passed to it through its constructor. This allows for the decoupling of `MyClass` from any specific implementation of `IMyDependency`, making it more flexible and easier to test.
