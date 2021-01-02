using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_Extension
{
    public class Engine
    {
        public void Run()
        {
            List<Vehicles> vehicles = new List<Vehicles>();
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split();
                vehicles.Add(CreateVehicle(input));
            }
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                GoVehicle(command, vehicles);
            }
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString()); 
            }
        }

        private void GoVehicle(string[] command, List<Vehicles> vehicles)
        {
            Vehicles vehicle = null;
            string vehicleType = command[1];
            if (vehicleType == "Car")
                vehicle = vehicles[0];
            else if (vehicleType == "Truck")
                vehicle = vehicles[1];
            else if (vehicleType == "Bus")
                vehicle = vehicles[2];
            if (command[0] == "Refuel")
                vehicle.Refueling(double.Parse(command[2]));
            else if (command[0] == "Drive")
                vehicle.Driving(double.Parse(command[2]));
            else if (command[0] == "DriveEmpty")
                (vehicle as Bus).DriveEmpty(double.Parse(command[2]));
        }

        private Vehicles CreateVehicle(string[] input)
        {
            Vehicles vehicle = null;
            string vehicleType = input[0];
            double fuel = double.Parse(input[1]);
            double consumption = double.Parse(input[2]);
            int tunkCapacity = int.Parse(input[3]);
            if (vehicleType == "Car")
                vehicle = new Car(fuel, consumption, tunkCapacity);
            else if (vehicleType == "Truck")
                vehicle = new Truck(fuel, consumption, tunkCapacity);
            else if (vehicleType == "Bus")
                vehicle = new Bus(fuel, consumption, tunkCapacity);
            else
                Console.WriteLine("Invalid vehicle type");
            return vehicle;
        }
    }
}
