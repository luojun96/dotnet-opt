namespace factory;

public class DevelopmentManager : HiringManager
{
    public override IInterviewer MakeInterviewer()
    {
        return new Developer();
    }
}
