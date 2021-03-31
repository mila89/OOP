namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        private Robot robot;
        private RobotManager manager;
        [SetUp]
        public void SetUp()
        {
            robot = new Robot("Test", 10);
            manager = new RobotManager(20);
        }
        
        
        [Test]
        public void WhenRobotIsCreated_SouldSetProperties()
        {
            Assert.AreEqual("Test", robot.Name);
            Assert.AreEqual(10, robot.Battery);
            Assert.AreEqual(10, robot.MaximumBattery);
        }

        [Test]
        public void WhenRobotManagerIsCreated_CapacityShouldBeSet()
        {
            Assert.AreEqual(20, manager.Capacity);

        }

        [Test]
        public void WhenRobotManagerCapacityIsNegative_ShouldThrowException()
        {
            Assert.AreEqual(0, manager.Count);
        }

        [Test]
        public void WhenRobotManagerCreated_CountShouldBeZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                RobotManager robManager = new RobotManager(-4);
            });
        }

        [Test]
        public void AddingSameRobot_ExceptionShouldBeThrown()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                manager.Add(robot);
                manager.Add(robot);
            });
        }

        [Test]
        public void AddingRobotOvarCapacity_ExceptionShouldBeThrown()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                RobotManager robotManager = new RobotManager(1);
                robotManager.Add(robot);
                robotManager.Add(new Robot("New",20));
            });
        }

        [Test]
        public void AddRobot_WithCorrectData()
        {
            manager.Add(robot);
            Assert.AreEqual(1, manager.Count);
            manager.Add(new Robot("New", 20));
            Assert.AreEqual(2, manager.Count);
        }
    }
}
