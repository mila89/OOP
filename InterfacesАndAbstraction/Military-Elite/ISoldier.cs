using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public interface ISoldier
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
