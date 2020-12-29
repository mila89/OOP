using System;
using System.Collections.Generic;
using System.Linq;

namespace Military_Elite
{
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");
            List<ISoldier> soldiers = new List<ISoldier>();
            List<Private> privates = new List<Private>();
            while (input[0]!="End")
            {
                string soldier = input[0];
                int id = int.Parse(input[1]);
                string firstName = input[2];
                string lastName = input[3];
                decimal salary = 0;
                if (input.Length>4)
                    salary = decimal.Parse(input[4]);

                switch (soldier)
                {
                    case "Private":
                        privates.Add(new Private(id, firstName, lastName, salary));
                        soldiers.Add(new Private(id, firstName, lastName, salary));
                        break;
                    case "Spy":
                        soldiers.Add(new Spy(firstName, lastName, id, int.Parse(input[4])));
                        break;
                    case "LieutenantGeneral":
                        soldiers = CreateLieutenantGeneral(input, privates, soldiers);
                        break;
                    case "Engineer":
                        soldiers = CreateEngineer(input,soldiers);
                        break;
                    case "Commando":
                        soldiers = CreateCommando(input, soldiers);
                        break;
                }
                input = Console.ReadLine().Split(" ");
            }
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString()); 
            }
        }

        private static List<ISoldier> CreateCommando(string[] input, List<ISoldier> soldiers)
        {
            int id = int.Parse(input[1]);
            string firstName = input[2];
            string lastName = input[3];
            decimal salary = decimal.Parse(input[4]);
            string corp= input[5];
            List<IMission> missions = new List<IMission>();
            for (int i = 6; i < input.Length; i+=2)
            {
                try
                {
                    missions.Add(new Mission(input[i], input[i + 1]));
                }
                catch //(Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                }
            }
            soldiers.Add(new Commando(id, firstName, lastName, salary, corp, missions));
            return soldiers;
        }

        private static List<ISoldier> CreateEngineer(string[] input, List<ISoldier> soldiersList)
        {
            int id = int.Parse(input[1]);
            string firstName = input[2];
            string lastName = input[3];
            decimal salary = decimal.Parse(input[4]);
            string corp = input[5];
            List<Repair> repairs = new List<Repair>();
            for (int i = 6; i < input.Length; i+=2)
            {
                repairs.Add(new Repair(input[i], int.Parse(input[i + 1])));
            }
            try
            {
                soldiersList.Add(new Engineer(id, firstName, lastName, salary, corp, repairs));
            }
            catch //(Exception ex)
            {
                //Console.WriteLine(ex.Message); 
            }
            return soldiersList;
        }

        private static List<ISoldier> CreateLieutenantGeneral(string[] input, List<Private> privates, List<ISoldier> soldiersList)
        {
            int id = int.Parse(input[1]);
            string firstName = input[2];
            string lastName = input[3];
            decimal salary = decimal.Parse(input[4]);
            List<Private> currentPrivates = new List<Private>();
            for (int i = 5; i < input.Length; i++)
            {
                Private currentPrivate=privates.FirstOrDefault(p => p.Id == int.Parse(input[i]));
                if (currentPrivate!= null)
                {
                    currentPrivates.Add(currentPrivate);
                }
            }
            soldiersList.Add(new LieutenantGeneral(id, firstName, lastName, salary, currentPrivates));
            return soldiersList;
        }

       
    }
}
