using System;
using System.Collections.Generic;

namespace BorderControl2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> inhabitants = new List<IIdentifiable>();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End")
            {
                if (input.Length == 3)
                    inhabitants.Add(new Citizens(input[0], int.Parse(input[1]), input[2]));
                else if (input.Length == 2)
                    inhabitants.Add(new Robots(input[0], input[1]));
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            string fake = Console.ReadLine();
            foreach (var inh in inhabitants)
            {
                if (!inh.ValidateId(fake))
                    Console.WriteLine(inh.Id);
            }
        }
    }
}
