using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, ICollection<Private> listPrivates):
            base(id, firstName, lastName, salary)
        {
            this.Privates = listPrivates;
        }

        public ICollection<Private> Privates { get; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {Math.Round(this.Salary,2):f2}");
            sb.Append("Privates:");
            foreach (var pr in this.Privates)
            {
                sb.AppendLine();
                sb.Append($"  {pr.ToString()}");
            }
            return sb.ToString();
        }
    }
}
