using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl2
{
    public class Robots: IIdentifiable
    {
        public Robots(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Id { get; set; }
        public string Model { get; set; }

        public bool ValidateId(string fake)
        {
            if (Id.EndsWith(fake))
                return false;
            return true;
        }
    }
}
