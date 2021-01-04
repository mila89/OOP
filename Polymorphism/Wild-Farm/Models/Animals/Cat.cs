using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals
{
   public  class Cat : Feline
    {
        public Cat(string name, double weight, string region, string breed) : base(name, weight, region, breed)
        {

        }
        public override double WeightMultiplyer => 0.30;

        public override ICollection<Type> PreferedFoods => new List<Type> { typeof(Vegetable), typeof(Meat)};

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
