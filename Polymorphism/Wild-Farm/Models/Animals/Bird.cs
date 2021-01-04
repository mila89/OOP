using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Animals
{
    public abstract class Bird:Animal 
    {
        public Bird(string name, double weight, double wingSize):base(name, weight)
        {
            this.WingSize = wingSize;
        }
        public double WingSize { get;}

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
