using System;
using System.Collections.Generic;

namespace Food_Shortage
{
    class StartUp
    {
        static void Main()
        {
            List<IBuyer> buyers = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string name = command[0];
                int age = int.Parse(command[1]);
                if (command.Length == 4)
                    buyers.Add(new Citizens(name, age, command[2], command[3]));
                else
                    buyers.Add(new Rebel(name, age, command[2]));
            }
            string nameBuyer = Console.ReadLine();
            while (nameBuyer != "End")
            {
                int index = ValidIndexName(nameBuyer, buyers);
                if (index > -1)
                {
                    buyers[index].BuyFood();
                }
                nameBuyer = Console.ReadLine();
            }
            int food = 0;
            foreach (var buyer in buyers)
            {
                food += buyer.Food;
            }
            Console.WriteLine(food);
        }
        private static int ValidIndexName(string name, List<IBuyer> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name)
                    return i;
            }
            return -1;
        }
    }
}
