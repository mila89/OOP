using System;
using System.Collections.Generic;

namespace Birthday_Celebrations
{
    class StartUp
    {
        public static void Main()
        {
            List<INamable> inhabitants = new List<INamable>();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End")
            {
                if (input.Length == 5)
                    inhabitants.Add(new Citizens(input[1], int.Parse(input[2]), input[3], input[4]));
                else if (input.Length == 3 && input[0].StartsWith("Pet"))
                    inhabitants.Add(new Pet(input[1], input[2]));
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            string year = Console.ReadLine();
            foreach (var inh in inhabitants)
            {
                if (inh.IsSameYear(year))
                    Console.WriteLine(inh.Birthday);
            }
        }
    }
}
