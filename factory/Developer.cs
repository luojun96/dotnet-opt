using System;

namespace factory
{
    class Developer : IInterviewer
    {
        public void AskQuestion()
        {
            Console.WriteLine("Ask about design pattern!");
        }
    }
}