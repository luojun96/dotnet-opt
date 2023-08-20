// See https://aka.ms/new-console-template for more information
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