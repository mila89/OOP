using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps):
            base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public string Corps { get { return this.corps; }
            set
            {
                if (value == "Airforces" || value == "Marines")
                    this.corps = value;
                else  
                    throw new ArgumentException("Invalid Corp");
            }
        
        }
    }
}
