using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Animals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string region):base(name, weight)
        {
            this.LivingRegion = region;
        }

        public string LivingRegion { get; }
        
    }
}
