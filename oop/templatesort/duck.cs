using System.Collections;

namespace templatesort
{
    class Duck : System.IComparable
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(object? obj)
        {
            Duck? otherDuck = (Duck?)obj;
            if(this.weight < otherDuck?.weight)
            {
                return -1;
            }
            else if (this.weight == otherDuck?.weight)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return name + " weights " + weight;
        }
    }
}