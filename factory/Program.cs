using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var devManager = new DevelopmentManager();
            devManager.TakeInterview();
        }
    }
}
