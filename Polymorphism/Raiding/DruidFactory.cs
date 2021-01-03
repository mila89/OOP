using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class DruidFactory : HeroFactory
    {
        private readonly string _name;
        private readonly int _power;

        public DruidFactory(string name, int power)
        {
            _name = name;
            _power = power;
        }
        public override BaseHero GetHero()
        {
            return new Druid(_name, _power);
        }
    }
}
