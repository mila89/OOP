using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, string corps, List<Mission> missionsList):
            base(id, firstName, lastName, salary, corps)
        {
            MissionsList = missionsList;
        }

        public List<Mission> MissionsList { get ; set ; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.Append("Missions:");
            foreach (var mission in this.MissionsList)
            {
                sb.AppendLine();
                sb.Append($"  {mission.ToString()}");
            }
            return sb.ToString();
        }
    }
}
