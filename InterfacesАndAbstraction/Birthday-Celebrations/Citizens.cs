using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations
{
    class Citizens:IIdentifiable, INamable
    {
        public Citizens(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }
        public string Id { get; set; }
        public string Name { get; private set; }
        public int Age { get; set; }

        public string Birthday { get; private set; } 

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
    }
}
