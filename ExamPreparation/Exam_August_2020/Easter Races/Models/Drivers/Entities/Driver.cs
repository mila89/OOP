using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Drivers.Entities
{
    public class Driver : IDriver
    {
        private string _name;

        public Driver(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this._name; }
            private set 
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Name {value} cannot be less than 5 symbols.");
                }
                this._name = value;
            }
        }

        public ICar Car { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate
        {
            get { return Car != null; }
        }

        public void AddCar(ICar car)
        {
            if (car != null)
            {
                this.Car = car;
            }
            else
                throw new ArgumentNullException("Car cannot be null.");
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }
    }
}
