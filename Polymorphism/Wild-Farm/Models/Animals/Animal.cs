using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Animals
{
    public abstract class Animal : Interfaces.IAnimal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }
        public string Name { get; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }
        public abstract double WeightMultiplyer { get; }
        public abstract ICollection<Type> PreferedFoods { get; }
        public void Eat(Foods.Interfaces.IFood food)
        {
            if (this.PreferedFoods.Contains(food.GetType()))
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * WeightMultiplyer;
            }
            else
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
        }

        public abstract string ProduceSound();
                
    }
}
