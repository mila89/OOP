using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string region):base(name,weight,region)
        {

        }
        public override double WeightMultiplyer => 0.40;

        public override ICollection<Type> PreferedFoods => new List<Type>{typeof(Meat)};

        public override string ProduceSound()
        {
            return "Woof!";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, { this.Weight}, { this.LivingRegion}, { this.FoodEaten}]";
        }
    }
}
