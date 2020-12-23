using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations
{
    public class Pet : INamable
    {
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
        public string Name { get; private set ; }
        public string Birthday { get; private set; }

        public bool IsSameYear(string year)
        {
            if (this.Birthday.EndsWith(year))
                return true;
            else
                return false;
        }
    }
}
