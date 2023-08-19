namespace template
{
    abstract class CaffeineBeverageWithHook
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }

        }

        public abstract void brew();

        public abstract void addCondiments();

        public void boilWater()
        {
            System.Console.WriteLine("Boiling water!");
        }

        public void pourInCup()
        {
            System.Console.WriteLine("Pouring into cup");
        }

        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}