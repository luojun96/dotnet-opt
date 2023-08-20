using System;
using System.Collections;

namespace templatesort
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = {
                new Duck("Daffy", 2),
                new Duck("Deway", 8),
                new Duck("Howare", 5)
            };
            Console.WriteLine("Before Sorting...");
            Display(ducks);
            Array.Sort(ducks);

            Console.WriteLine("After sorting...");
            Display(ducks);
        }

        static void Display(Duck[] ducks)
        {
            foreach (var item in ducks)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
