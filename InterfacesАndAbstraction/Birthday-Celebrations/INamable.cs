using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations
{
    public interface INamable
    {
        public string Name { get; }
        public string Birthday { get; }
        public bool IsSameYear(string year);
    }
}
