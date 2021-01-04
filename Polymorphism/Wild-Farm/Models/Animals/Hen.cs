using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Foods;
using Wild_Farm.Models.Foods.Interfaces;

namespace Wild_Farm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize):base (name, weight, wingSize)
        {

        }
        public override double WeightMultiplyer => 0.35;

        public override ICollection<Type> PreferedFoods => 
            new List<Type> {typeof(Vegetable), typeof(Meat), typeof(Seeds), typeof(Fruit)};

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
