using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars.Entities
{
    
    public class SportsCar:Car,ICar
    {
        //private int horsePower;
        private int minHorsePower;
        private int maxHorsePower;
        public SportsCar(string model, int horsePower)
            : base(model)
        {
            this.minHorsePower = 250;
            this.maxHorsePower = 450;
            this.HorsePower = horsePower;
            this.cubicCentimeters = 3000;
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
