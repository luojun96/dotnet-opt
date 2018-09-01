using System;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var devManager = new DevelopmentManager();
            devManager.TakeInterview();

            var communityManager = new CommunityManager();
            communityManager.TakeInterview();
        }
    }
}
