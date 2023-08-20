namespace factory;

public abstract class HiringManager
{
    // Factory method
    public abstract IInterviewer MakeInterviewer();

    public void TakeInterview()
    {
        var interviewer = this.MakeInterviewer();
        interviewer.AskQuestions();
    }
}
