using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Models.Races.Entities
{
    public class Race : IRace
    {
        private string _name;
        private int _lap;
        private List<IDriver> _drivers;

        public Race(string name, int lap)
        {
            this.Name = name;
            this.Laps = lap;
            _drivers = new List<IDriver>();
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

        public int Laps
        {
            get { return this._lap; }
            private set 
            {
                if (value < 1)
                    throw new ArgumentException("Laps cannot be less than 1.");
            }
        }

        public IReadOnlyCollection<IDriver> Drivers
        {
            get {return this._drivers.AsReadOnly(); }
        }

        public void AddDriver(IDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException("Driver cannot be null.");
            }
            if (!driver.CanParticipate)
            {
                throw new ArgumentException($"Driver {driver.Name} could not participate in race.");
            }
            if (FindDriver(driver))
            {
                throw new ArgumentNullException($"Driver {driver.Name} is already added in {this.Name} race.");
            }
            this._drivers.Add(driver);
        }

        private bool FindDriver(IDriver driver)
        {
            if (this.Drivers.FirstOrDefault(x => x.Name == driver.Name) != null)
                return true;
            else
                return false;
        }
    }
}
