namespace factory
{
    class CommunityManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
