using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public abstract class Soldier: ISoldier
    {
        public Soldier(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }
        public string FirstName { get;  }
        public string LastName { get;  }
        public int Id { get;}
        
    }
}
