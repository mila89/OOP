using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public interface ISoldier
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Id { get;}
    }
}
