using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Team_Generator
{
    public class Stats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int end, int sprint, int dribble, int pass, int shoot)
        {
            this.Endurance = end;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = pass;
            this.Shooting = shoot;
        }
        public int Endurance
        {
            get { return this.endurance; }
            private set
            {
                ValidateData("Endurance", value);
                this.endurance = value;
            }
        }
        public int Sprint
        {
            get { return this.sprint; }
            private set
            {
                ValidateData("Sprint", value);
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get { return this.dribble; }
            private set
            {
                ValidateData("Dribble", value);
                this.dribble = value;
            }
        }
        public int Passing
        {
            get { return this.passing; }
            private set
            {
                ValidateData("Passing", value);
                this.passing = value;
            }
        }
        public int Shooting
        {
            get { return this.shooting; }
            private set
            {
                ValidateData("shooting", value);
                this.shooting = value;
            }
        }

        public double AverageStat  => (this.Endurance + this.Dribble + this.Passing + this.Shooting + this.Sprint) / 5.0;
        


        private void ValidateData(string v, int value)
        {
            if (value < 0 || value > 100)
                throw new ArgumentException($"{v} should be between 0 and 100.");
        }
    }
}
