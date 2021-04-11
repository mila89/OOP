using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars
{
    public abstract class Car : ICar
    {

        private string _model;
        protected int horsePower;
  //      internal int minHorsePower;
    //    internal int maxHorsePower;
        internal int cubicCentimeters;

        public Car(string model)
        {
            this.Model = model;
            //this.HorsePower = horsePower;
        }
        public string Model
        {
            get { return this._model; }

            private set
            {
                if ((String.IsNullOrWhiteSpace(value)) || (value.Length < 4))
                {
                    throw new ArgumentException($"Model {value} cannot be less than 4 symbols.");
                }
                this._model = value;
            }
        }

        public abstract int HorsePower{ get; protected set; }

        public double CubicCentimeters { get { return this.cubicCentimeters; } }

        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / this.HorsePower * laps;
        }
    }
}
