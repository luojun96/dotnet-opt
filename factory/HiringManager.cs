using System;

namespace factory
{
    abstract class HiringManager
    {
        abstract protected IInterviewer MakeInterviewer();
        public void TakeInterview()
        {
            var interviewwer = this.MakeInterviewer();
            interviewwer.AskQuestion();
        }
    }
}
