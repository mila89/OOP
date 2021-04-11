using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    public class MuscleCar:Car,ICar
    {
       // private int horsePower;
        private int minHorsePower;
        private int maxHorsePower;

        public MuscleCar(string model, int horsePower)
            :base(model)
        {
            this.minHorsePower = 400;
            this.maxHorsePower = 600;
            this.HorsePower = horsePower;
            this.cubicCentimeters = 5000;
        }

        public override int HorsePower 
        {
            get { return this.horsePower; }
            protected set
            {
                if (value > this.maxHorsePower || value < this.minHorsePower)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
            }
        }
    }
}
