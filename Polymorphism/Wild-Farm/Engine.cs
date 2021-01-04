using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Animals;
using Wild_Farm.Models.Animals.Interfaces;
using Wild_Farm.Models.Foods;

namespace Wild_Farm
{
    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            string[] input = Console.ReadLine().Split();
            List<IAnimal> animals = new List<IAnimal>();
            while (input[0] != "End")
            {
                string type = input[0];
                switch (type)
                {
                    case "Owl":
                        animals=OperateOwl(input, animals);
                        break;
                    case "Hen":
                        animals = OperateHen(input, animals);
                        break;
                    case "Mouse":
                        animals = OperateMouse(input, animals);
                        break;
                    case "Dog":
                        animals = OperateDog(input, animals);
                        break;
                    case "Cat":
                        animals = OperateCat(input, animals);
                        break;
                    case "Tiger":
                        animals = OperateTiger(input, animals);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine().Split();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private List<IAnimal> OperateTiger(string[] input, List<IAnimal> animals)
        {
            string name = input[1];
            double weight = double.Parse(input[2]);
            Animal animal = new Tiger(name, weight, input[3], input[4]);
            string[] inputFood = Console.ReadLine().Split();
            Food food = CreateFood(inputFood);
            Console.WriteLine(animal.ProduceSound());
            animal.Eat(food);
            animals.Add(animal);
            return animals;
        }

        private List<IAnimal> OperateDog(string[] input, List<IAnimal> animals)
        {
            string name = input[1];
            double weight = double.Parse(input[2]);
            Animal animal = new Dog(name, weight, input[3]);
            string[] inputFood = Console.ReadLine().Split();
            Food food = CreateFood(inputFood);
            Console.WriteLine(animal.ProduceSound());
            animal.Eat(food);
            animals.Add(animal);
            return animals;
        }

        private List<IAnimal> OperateCat(string[] input, List<IAnimal> animals)
        {
            string name = input[1];
            double weight = double.Parse(input[2]);
            Animal animal = new Cat(name, weight, input[3], input[4]);
            string[] inputFood = Console.ReadLine().Split();
            Food food = CreateFood(inputFood);
            Console.WriteLine(animal.ProduceSound());
            animal.Eat(food);
            animals.Add(animal);
            return animals;
        }
        private List<IAnimal> OperateMouse(string[] input, List<IAnimal> animals)
        {
            string name = input[1];
            double weight = double.Parse(input[2]);
            Animal animal = new Mouse(name, weight, input[3]);
            string[] inputFood = Console.ReadLine().Split();
            Food food = CreateFood(inputFood);
            Console.WriteLine(animal.ProduceSound());
            animal.Eat(food);
            animals.Add(animal);

            return animals;
        }

        private List<IAnimal> OperateHen(string[] input, List<IAnimal> animals)
        {
            string name = input[1];
            double weight = double.Parse(input[2]);
            Animal animal = new Hen(name, weight, double.Parse(input[3]));
            string[] inputFood = Console.ReadLine().Split();
            Food food = CreateFood(inputFood);
            Console.WriteLine(animal.ProduceSound());
            animal.Eat(food);
            animals.Add(animal);
            return animals;
        }

        private List<IAnimal> OperateOwl(string[] input, List<IAnimal> animals)
        {
            string name = input[1];
            double weight = double.Parse(input[2]);
            
            Animal animal = new Owl(name, weight, double.Parse(input[3]));
            string[] inputFood = Console.ReadLine().Split();
            Food food = CreateFood(inputFood);
            Console.WriteLine(animal.ProduceSound());
            animal.Eat(food);
            animals.Add(animal);
            return animals;
        }

        private Food CreateFood(string[] inputFood)
        {
            Food result = null;
            string typeFood = inputFood[0];
            int quantity = int.Parse(inputFood[1]);
            switch (typeFood)
            {
                case "Vegetable":
                    result = new Vegetable(quantity);
                    break;
                case "Fruit":
                    result = new Fruit(quantity);
                    break;
                case "Meat":
                    result = new Meat(quantity);
                    break;
                case "Seeds":
                    result = new Seeds(quantity);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
