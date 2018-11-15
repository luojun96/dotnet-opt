using System;

namespace template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CoffeeWithHook coffee = new CoffeeWithHook();
            coffee.prepareRecipe();
        }
    }
}
