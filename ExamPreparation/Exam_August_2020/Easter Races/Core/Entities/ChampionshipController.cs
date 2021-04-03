using EasterRaces.Core.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EasterRaces.Models.Cars;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private DriverRepository driveRep;
        private CarRepository carRep;
        private RaceRepository raceRep;
        public ChampionshipController()
        {
            driveRep = new DriverRepository();
            carRep = new CarRepository();
            raceRep = new RaceRepository();
        }
        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver currentDriver = driveRep.GetByName(driverName);
            ICar currentCar = carRep.GetByName(carModel);
            if (currentDriver == null)
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            if (currentCar==null)
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            currentDriver.AddCar(currentCar);
            return $"Driver {driverName} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            IRace currentRace = raceRep.GetByName(raceName);
            IDriver currentDriver = driveRep.GetByName(driverName);
            if (currentRace == null)
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            if (currentDriver == null)
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            currentRace.AddDriver(currentDriver);
            return $"Driver {driverName} added in {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            var car = this.carRep.GetByName(model);
            if (car!=null)
            {
                throw new ArgumentException($"Car {model} is already create.");
            }
            Car newCar=null;
            if (type == "Muscle")
                newCar = new MuscleCar(model, horsePower);
            else if (type == "Sports")
                newCar = new SportsCar(model, horsePower);
            carRep.Add(newCar);
            return $"{type}Car {model} is created.";
        }

        public string CreateDriver(string driverName)
        {
            var driver=driveRep.GetByName(driverName);
            Driver newDriver = new Driver(driverName);
            if (driver!=null)
                throw new ArgumentException($"Driver {driverName} is already created.");
            else
            {
                driveRep.Add(newDriver);
                return $"Driver {driverName} is created.";
            }
        }

        public string CreateRace(string name, int laps)
        {
            IRace currentRace = raceRep.GetByName(name);
            if (currentRace != null)
                throw new InvalidOperationException($"Race {name} is already create.");
            IRace newRace = new Race(name,laps);
            raceRep.Add(newRace);
            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            IRace currentRace = raceRep.GetByName(raceName);
            if (currentRace == null)
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            if (currentRace.Drivers.Count < 3)
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");

            var drivers = currentRace.Drivers
                            .OrderByDescending(x => x.Car.CalculateRacePoints(currentRace.Laps)).ToList();

            var first = drivers[0];
            var second = drivers[1];
            var third = drivers[2];
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Driver {first.Name} wins {currentRace.Name} race.");
            result.AppendLine($"Driver {second.Name} is second in {currentRace.Name} race.");
            result.Append($"Driver {third.Name} is third in {currentRace.Name} race.");
            raceRep.Remove(currentRace);
            return result.ToString().TrimEnd();
        }
    }
}
