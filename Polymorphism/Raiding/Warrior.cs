using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Warrior:BaseHero
    {
        private readonly string typeHero;
        private string _name;
        private int _power;

        public Warrior(string name, int power)
        {
            _name = name;
            _power = power;
            typeHero = "Warrior";
        }
        public override string Name { get => _name; set => _name=value; }
        public override int Power { get => _power; set => _power=value; }

        public override string HeroType => typeHero;

        public override string CastAbility()
        {
            return $"{this.HeroType} - {this.Name} hit for {this.Power} damage";
        }
    }
}
