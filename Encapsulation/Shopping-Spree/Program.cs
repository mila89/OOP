using System;
using System.Collections.Generic;

namespace Shopping
{
    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            try
            {
                string[] input = Console.ReadLine().Split(";=".ToCharArray());
                people = TakePeople(input);
                input = Console.ReadLine().Split(";=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                products = TakeProducts(input);
                input = Console.ReadLine().Split();
                while (input[0] != "END")
                {
                    people = ExecuteCommands(people, products, input);
                    input = Console.ReadLine().Split();
                }
                PrintResults(people);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private static void PrintResults(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.Write($"{people[i].Name} - ");
                if (people[i].Bag.Count == 0)
                    Console.WriteLine("Nothing bought");
                else
                {
                    for (int j = 0; j < people[i].Bag.Count; j++)
                    {
                        if (j == people[i].Bag.Count - 1)
                            Console.Write(people[i].Bag[j]);
                        else
                            Console.Write($"{people[i].Bag[j]}, ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static List<Person> ExecuteCommands(List<Person> people, List<Product> products, string[] input)
        {
            Person currentPerson = FindPerson(input[0], people);
            double currentPrice = FindPriceProduct(input[1], products);
            if (currentPerson.Money < currentPrice)
                Console.WriteLine($"{currentPerson.Name} can't afford {input[1]}");
            else
            {
                currentPerson.Money -= currentPrice;
                currentPerson.AddInBag(input[1]);
                Console.WriteLine($"{currentPerson.Name} bought {input[1]}");
            }
            return people;
        }

        private static List<Product> TakeProducts(string[] input)
        {
            List<Product> productsList = new List<Product>();
            for (int i = 0; i < input.Length; i += 2)
            {
                productsList.Add(new Product(input[i], int.Parse(input[i + 1])));
            }
            return productsList;
        }

        private static List<Person> TakePeople(string[] input)
        {
            //if (input.Length % 2 != 0)
            //    throw new ArgumentException("Name cannot be empty");
            List<Person> people = new List<Person>();

            for (int i = 0; i < input.Length; i += 2)
            {
                people.Add(new Person(input[i], int.Parse(input[i + 1])));
            }
            return people;
        }

        private static double FindPriceProduct(string nameProduct, List<Product> products)
        {
            foreach (var product in products)
            {
                if (product.Name == nameProduct)
                    return product.Cost;
            }
            return -1;
        }

        private static Person FindPerson(string name, List<Person> list)
        {
            foreach (var person in list)
            {
                if (person.Name == name)
                    return person;
            }
            return null;
        }
    }
}
