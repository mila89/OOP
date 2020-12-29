using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Engineer :SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairsList):
            base (id, firstName, lastName, salary, corps)
        {
            RepairsList = repairsList;
        }

        public ICollection<Repair> RepairsList { get ;  }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {Math.Round(this.Salary,2):f2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.Append("Repairs:");
            foreach (var repair in this.RepairsList)
            {
                sb.AppendLine();
                sb.Append($"  {repair.ToString()}");
            }
            return sb.ToString();
        }
    }
}
