﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IPerson
    {
        public string Name { get; set; }
        int Age { get; set; }
    }
}
