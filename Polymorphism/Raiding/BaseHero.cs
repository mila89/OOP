﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
         public abstract string Name { get; set; }
         public abstract int Power { get; set; }
         public abstract string HeroType { get; }
         public abstract string CastAbility();
        
    }
}
