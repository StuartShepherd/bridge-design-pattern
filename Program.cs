using BridgeDesignPattern;

Console.WriteLine("Bridge Design Pattern");
Console.WriteLine("Bridge is a structural design pattern that divides business logic or huge class into separate class hierarchies that can be developed independently.");
Console.WriteLine();

var client = new Client();

var abstraction = new Abstraction(new ConcreteImplementationAlpha());
client.ClientCode(abstraction);
Console.WriteLine();

abstraction = new ExtendedAbstraction(new ConcreteImplementationBeta());
client.ClientCode(abstraction);
Console.WriteLine();