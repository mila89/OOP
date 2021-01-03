using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    class WarriorFactory:HeroFactory
    {
        private string _name;
        private int _power;
        public WarriorFactory(string name, int power)
        {
            _name = name;
            _power = power;
        }
        public override BaseHero GetHero()
        {
            return new Warrior(_name, _power);
        }
    }
}
