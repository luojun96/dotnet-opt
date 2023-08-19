// See https://aka.ms/new-console-template for more information
using decorator;
Beverage beverage = new Espresso();

System.Console.WriteLine($"{beverage.GetDescription()} {beverage.Cost()}");

beverage = new Mocha(beverage);
beverage = new Mocha(beverage);
beverage = new Mocha(beverage);

System.Console.WriteLine($"{beverage.GetDescription()} {beverage.Cost()}");