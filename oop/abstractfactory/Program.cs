// See https://aka.ms/new-console-template for more information
using abstractfactory;

Console.WriteLine("Hello, World!");

IAbstractFactory factory1 = new ConcreteFactory1();

IProductA productA1 = factory1.CreateProductA();
IProductB productB1 = factory1.CreateProductB();

productA1.DoSomething();
productB1.DoSomething();