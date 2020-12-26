using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public interface IRepair
    {
        public string PartName { get; set; }
        public int Hours { get; set; }
    }
}
