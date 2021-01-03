using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class RogueFactory:HeroFactory
    {
        private string _name;
        private int _power;
        public RogueFactory(string name, int power)
        {
            _name = name;
            _power = power;
        }
        public override BaseHero GetHero()
        {
            return new Rogue(_name, _power);
        }
    }
}
