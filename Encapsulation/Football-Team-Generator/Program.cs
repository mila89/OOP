using System;
using System.Collections.Generic;

namespace Football_Team_Generator
{
    class Program
    {
        static void Main()
        {
            List<Team> teamList = new List<Team>();
            string[] command = Console.ReadLine().Split(";");

            while (command[0] != "END")
            {
                try
                {
                    if (command[0] == "Team")
                    {
                        teamList.Add(new Team(command[1]));
                    }
                    else if (command[0] == "Add")
                    {
                        int index = FindTeam(command[1], teamList);
                        if (index >= 0)
                        {
                            Stats stats = new Stats(int.Parse(command[3]), int.Parse(command[4]),
                                int.Parse(command[5]), int.Parse(command[6]), int.Parse(command[7]));
                            Player newPlayer = new Player(command[2], stats);
                            teamList[index].AddPlayer(newPlayer);
                        }
                    }
                    else if (command[0] == "Remove")
                    {
                        int index = FindTeam(command[1], teamList);
                        if (index==-1)
                            Console.WriteLine($"Team {command[1]} does not exist.");
                        else
                            teamList[index].RemovePlayer(command[2]);
                    }
                    else if (command[0] == "Rating")
                    {
                        int index = FindTeam(command[1], teamList);
                        if (index==-1)
                            Console.WriteLine($"Team {command[1]} does not exist.");
                        else
                            Console.WriteLine($"{teamList[index].Name} - {teamList[index].Rating}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                command = Console.ReadLine().Split(";");
            }
        }

        private static int FindTeam(string v, List<Team> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == v)
                    return i;
            }
            return -1;
        }
    }
}
