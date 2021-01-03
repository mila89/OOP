using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Engine
    {
        public Engine()
        {
                
        }

        public void Run()
        {
            List<BaseHero> raidGroup = new List<BaseHero>();
            HeroFactory factory = null;

            int n = int.Parse(Console.ReadLine());
            while (raidGroup.Count<n)
            { 
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                bool validHero = true;
                switch (type)
                {
                    case "Paladin":
                        factory = new PaladinFactory(name, 100);
                        break;
                    case "Druid":
                        factory = new DruidFactory(name, 80);
                        break;
                    case "Warrior":
                        factory = new WarriorFactory(name, 100);
                        break;
                    case "Rogue":
                        factory = new RogueFactory(name, 80);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        validHero = false;
                        break;
                }
                if (validHero)
                    raidGroup.Add(factory.GetHero());
            }
            int sumPower = 0;
            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility()); 
                sumPower += hero.Power;
            }
            int boss = int.Parse(Console.ReadLine());
            if (boss>sumPower)
                Console.WriteLine("Defeat...");
            else
                Console.WriteLine("Victory!");
        }
    }
}
