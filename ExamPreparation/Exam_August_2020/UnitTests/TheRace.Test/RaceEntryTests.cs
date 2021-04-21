using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        //private const int MinParticipants = 2;
        [SetUp]
        public void Setup()
        {
            //UnitCar car = new UnitCar("Ferrari", 200, 300);
            //UnitDriver driver = new UnitDriver("Pesho", car);
            //RaceEntry race = new RaceEntry();
        }

        
        [Test]
        public void WhenAddingEmptyDriver_ExceptionShouldBeTrown()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                RaceEntry raceEx = new RaceEntry();
                raceEx.AddDriver(null);
            });
        }

        [Test]
        public void WhenAddingExistedDriver_ExceptionShouldBeTrown()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {

                UnitCar car = new UnitCar("Ferrari", 200, 300);
                UnitDriver driver = new UnitDriver("Pesho", car);
                RaceEntry raceEx = new RaceEntry();
                raceEx.AddDriver(driver);
                raceEx.AddDriver(driver);
            });
        }

        [Test]
        public void WhenAddingCorrectDriver_ShouldWork()
        {
            UnitCar car = new UnitCar("Ferrari", 200, 300);
            UnitDriver driver = new UnitDriver("Pesho", car);
            RaceEntry raceEx = new RaceEntry();
            var result= raceEx.AddDriver(driver);
            Assert.AreEqual("Driver Pesho added in race.",result);
            Assert.AreEqual(raceEx.Counter, 1);
            
        }

        [Test]
        public void WhenCalculateAverageHorsePowerDriverCountIsLessThanMinParticipiants_ShouldThrowWxceptionk()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                UnitCar car1 = new UnitCar("Ferrari", 20, 30);
                UnitDriver driver3 = new UnitDriver("Tania", car1);
                RaceEntry raceEx = new RaceEntry();
                var result=raceEx.AddDriver(driver3);
                raceEx.CalculateAverageHorsePower();
            });
        }

        [Test]
        public void CalculateAverageHorsePowerWithEnoughParticipiants_ShouldWorkCorrectly()
        {
            UnitCar car1 = new UnitCar("Ferrari", 30, 30);
            UnitCar car2 = new UnitCar("Lada", 200, 300);
            UnitCar car3 = new UnitCar("Porshe", 100, 300);
            UnitDriver driver1 = new UnitDriver("Pesho", car1);
            UnitDriver driver2 = new UnitDriver("Gosho", car2);
            UnitDriver driver3 = new UnitDriver("Tania", car3);
            RaceEntry raceEx = new RaceEntry();
            raceEx.AddDriver(driver1);
            raceEx.AddDriver(driver2);
            raceEx.AddDriver(driver3);
            var result = raceEx.CalculateAverageHorsePower();
            Assert.AreEqual(result, 110);
        }
    }
}