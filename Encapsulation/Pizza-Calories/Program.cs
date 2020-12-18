using System;

namespace Pizza
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Pizza pizza=null;

            try
            {
                while (input[0] != "END")
                {
                    input[0] = input[0].ToLower();
                    if (input[0] == "pizza")
                    {
                        pizza = new Pizza(input[1]);
                    }
                    if (input[0] == "dough")
                    {
                        Dough d = new Dough(input[1], input[2], int.Parse(input[3]));
                        pizza.Dough = d;
                    }
                    else if (input[0] == "topping")
                    {
                        Topping top = new Topping(input[1], int.Parse(input[2]));
                        pizza.Toppings.Add(top);
                    }
                    input = Console.ReadLine().Split();
                }
                Console.WriteLine($"{pizza.Name} - {pizza.Calories:f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                
            }
        }
}
