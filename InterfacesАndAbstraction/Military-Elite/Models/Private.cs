using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Private : Soldier,IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary) : base(firstName, lastName, id)
        {
            this.Salary = salary;
        }
        public decimal Salary { get; }
        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {Math.Round(this.Salary,2):f2}";
        }
    }
}
