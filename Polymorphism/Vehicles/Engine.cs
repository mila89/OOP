using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Engine
    {
        public void Run()
        {
            string[] inputCar = Console.ReadLine().Split();
            string[] inputTruck = Console.ReadLine().Split();
            Vehicles currentCar = new Car(double.Parse(inputCar[1]), double.Parse(inputCar[2]));
            Vehicles currentTruck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[1] == "Car")
                {
                    if (command[0] == "Drive")
                    {
                        currentCar.Driving(double.Parse(command[2]));
                    }
                    else if (command[0] == "Refuel")
                    {
                        currentCar.Refueling(double.Parse(command[2]));
                    }
                }
                else if (command[1] == "Truck")
                {
                    if (command[0] == "Drive")
                    {
                        currentTruck.Driving(double.Parse(command[2]));
                    }
                    else if (command[0] == "Refuel")
                    {
                        currentTruck.Refueling(double.Parse(command[2]));
                    }
                }
            }
            Console.WriteLine($"Car: {Math.Round(currentCar.Quantity, 2, MidpointRounding.AwayFromZero):f2}");
            Console.WriteLine($"Truck: {Math.Round(currentTruck.Quantity, 2, MidpointRounding.AwayFromZero):f2}");
        }
    }
}
