namespace factory;

public class CommunityManager : HiringManager
{
    public override IInterviewer MakeInterviewer()
    {
        return new CommunityExecutive();
    }
}