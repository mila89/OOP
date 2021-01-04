using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Animals
{
    public class Owl:Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplyer => 0.25;

        public override ICollection<Type> PreferedFoods => new List<Type> { typeof(Foods.Meat) };

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
