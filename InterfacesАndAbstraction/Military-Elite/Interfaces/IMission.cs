using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public interface IMission
    {
         string CodeName { get; }
         string State { get;  }
         void CompleteMission();
    }
}
