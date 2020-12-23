using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl2
{
    public interface IIdentifiable
    {
        string Id { get; set; }
        bool ValidateId(string fake);
    }
}
