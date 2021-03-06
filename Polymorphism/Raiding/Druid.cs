﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class Druid:BaseHero
    {
        private readonly string typeHero;
        private string _name;
        private int _power;

        public Druid(string name, int power)
        {
            typeHero = "Druid";
            _name = name;
            _power = power;
        }
        public override string HeroType => typeHero;

        public override string Name { get => _name; set => _name=value; }
        public override int Power { get => _power; set => _power=value; }

        public override string CastAbility()
        {
            return $"{this.HeroType} - {this.Name} healed for {this.Power}";
        }
    }
}
