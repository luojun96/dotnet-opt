namespace template
{
    class CoffeeWithHook : CaffeineBeverageWithHook
    {
        public override void addCondiments()
        {
            System.Console.WriteLine("Dripping Coffee through filter");
        }

        public override void brew()
        {
            System.Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool customerWantsCondiments()
        {
            return true;
        } 
    }
}