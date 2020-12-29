using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public enum CorpEnum
    {
        Airforces = 1,
        Marines = 2
    }
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps):
            base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public string Corps { get { return this.corps; }
            private set
            {
                CorpEnum corps;
                if (!Enum.TryParse<CorpEnum>(value, out corps))
                    throw new ArgumentException("Invalid Corp");
                this.corps = value;
            }
        
        }
    }
}
