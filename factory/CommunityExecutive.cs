using System;

namespace factory
{
    class CommunityExecutive : IInterviewer
    {
        public void AskQuestion()
        {
            Console.WriteLine("Ask about community building!");
        }
    }
}
