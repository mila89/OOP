using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Animals
{
    public abstract class Feline:Mammal
    {
        public Feline(string name, double weight, string region, string breed):base(name,weight,region)
        {
            this.Breed = breed;
        }

        public string Breed { get; }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, { this.Breed}, {this.Weight}, {this.LivingRegion}, { this.FoodEaten}]";
        }
    }
}
