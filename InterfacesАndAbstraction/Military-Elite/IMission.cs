﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public interface IMission
    {
        public string CodeName { get; set; }
        public string State { get; set; }
        public void CompleteMission();
    }
}
