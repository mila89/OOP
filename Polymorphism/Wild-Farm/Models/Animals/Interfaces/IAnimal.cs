using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Animals.Interfaces
{
    public interface IAnimal
    {
        public string Name { get; }
        public double Weight { get; }
        public int FoodEaten { get; }
        public string ProduceSound();
    }
}
