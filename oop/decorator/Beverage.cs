namespace decorator
{
    public abstract class Beverage
    {
        protected string description = "Unknow Beverage";
        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}