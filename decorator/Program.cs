using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage beverage = new Espresso();

            System.Console.WriteLine($"{beverage.GetDescription()} {beverage.Cost()}");

            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            
            System.Console.WriteLine($"{beverage.GetDescription()} {beverage.Cost()}");
        }
    }
}
