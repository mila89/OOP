using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl2
{
    public class Citizens: IIdentifiable
    {
        public Citizens(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public bool ValidateId(string fake)
        {
            if (Id.EndsWith(fake))
                return false;
            return true;
        }
    }
}
