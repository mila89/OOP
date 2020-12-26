using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Engineer :SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, List<Repair> repaiersList):
            base (id, firstName, lastName, salary, corps)
        {
            RepaiersList = repaiersList;
        }

        public List<Repair> RepaiersList { get ; set ; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.Append("Repairs:");
            foreach (var repair in this.RepaiersList)
            {
                sb.AppendLine();
                sb.Append($"  {repair.ToString()}");
            }
            return sb.ToString();
        }
    }
}
