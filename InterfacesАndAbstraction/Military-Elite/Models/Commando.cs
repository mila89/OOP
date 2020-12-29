using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly ICollection<IMission> missions;
        public Commando(int id, string firstName, string lastName, decimal salary, string corps, ICollection<IMission> missionsList) :
            base(id, firstName, lastName, salary, corps)
         {
             this.missions = missionsList;
         }
        public ICollection<IMission> Missions { get { return this.missions; } }

        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {Math.Round(this.Salary,2):f2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.Append("Missions:");
            foreach (var mission in this.Missions)
            {
                sb.AppendLine();
                sb.Append($"  {mission.ToString()}");
            }
            return sb.ToString();
        }
    }
}
