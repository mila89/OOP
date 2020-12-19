using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Team_Generator
{
    public class Player
    {
        private string name;

        public Player(string name,Stats stat)
        {
            this.name = name;
            this.Stats = stat;
        }

        public string Name 
        { 
            get { return this.name; }
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A name should not be empty.");
            }
        }

        public Stats Stats { get; set; }
        public double OverallSkill => this.Stats.AverageStat;
    }
}
