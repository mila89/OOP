using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator
{
    public class Team
    {
        private string name;
        private List<Player> playerList;

        public Team(string name)
        {
            this.Name = name;
            playerList = new List<Player>();
        }

        public int Rating 
        {
            get 
            {
                double result = 0;
                for (int i = 0; i < this.playerList.Count; i++)
                {
                    result += playerList[i].OverallSkill;
                }
                return (int)Math.Round(result,0, MidpointRounding.AwayFromZero);
             } 
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A name should not be empty.");
                this.name = value;
            }
        }

        public void AddPlayer(Player pl)
        {
            this.playerList.Add(pl);
        }

        public void RemovePlayer(string name)
        {
            Player playerToRemove = this.playerList.FirstOrDefault(p => p.Name == name);
            if (playerToRemove !=null)
                this.playerList.Remove(playerToRemove);
            else
                throw new ArgumentException($"Player {name} is not in {this.Name} team.");
        }
    }
}
