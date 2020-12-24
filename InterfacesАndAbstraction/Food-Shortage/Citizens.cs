using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Shortage
{
    public class Citizens:IBuyer
    {
        public Citizens(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
            this.Food = 0;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string Birthday { get; private set; }
        public int Food { get; set; }

        public bool ValidateId(string fake)
        {
            if (Id.EndsWith(fake))
                return false;
            return true;
        }

        public bool IsSameYear(string year)
        {
            if (this.Birthday.EndsWith(year))
                return true;
            else
                return false;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
