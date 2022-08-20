namespace BridgeDesignPattern;

public class Abstraction
{
    protected IImplementation _implementation;

    public Abstraction(IImplementation implementation)
    {
        _implementation = implementation;
    }

    public virtual string Operation() =>
        "Abstract: Base operation with:\n" +
            _implementation.OperationImplementation();
}
