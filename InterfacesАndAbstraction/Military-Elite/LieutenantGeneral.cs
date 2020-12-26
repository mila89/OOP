using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, List<Private> listPrivates):
            base(id, firstName, lastName, salary)
        {
            ListPrivates = listPrivates;
        }

        public List<Private> ListPrivates { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
            sb.Append("Privates:");
            foreach (var pr in this.ListPrivates)
            {
                sb.AppendLine();
                sb.Append($"  {pr.ToString()}");
            }
            return sb.ToString();
        }
    }
}
