

namespace BurgerShack2.Models
{
    public class Burger
    {
        public Burger(string name, string meat, string cheese, int numPatties, bool haveOnions, int id)
        {
            Name = name;
            Meat = meat;
            Cheese = cheese;
            NumPatties = numPatties;
            HaveOnions = haveOnions;
            Id = id;
        }

        public string Name {get; set; }
        public string Meat {get; set; }
        public string Cheese {get; set; }
        public int NumPatties {get; set; }
        public bool HaveOnions {get; set; }
        public int Id {get; set; }
    }
}