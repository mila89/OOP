using System;
using System.Collections.Generic;

namespace Explicit_Interfaces
{
    public class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            var list = new List<Citizen>();
            while (input[0]!="End")
            {
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);
                list.Add(new Citizen(name, country, age)); 
                input = Console.ReadLine().Split();
            }

            foreach (var citizen in list)
            {
                var controlPerson = citizen as IPerson;
                Console.WriteLine(controlPerson.GetName());
                var controlResident = citizen as IResident;
                Console.WriteLine(controlResident.GetName());

            }
        }
    }
}
