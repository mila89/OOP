using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string firstName, string lastName, int id, int codeNumber):
            base(firstName, lastName, id)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get ; set ; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}
