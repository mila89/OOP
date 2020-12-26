using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public interface ICommando
    {
        public List<Mission> MissionsList { get; set; }
    }
}
