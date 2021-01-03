using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class PaladinFactory : HeroFactory
    {
        private string _name;
        private int _power;
        public PaladinFactory(string name, int power)
        {
            _name = name;
            _power = power;
        }
        public override BaseHero GetHero()
        {
            return new Paladin(_name, _power);
        }
    }
}
