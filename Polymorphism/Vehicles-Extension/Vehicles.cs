using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_Extension
{
    public abstract class Vehicles
    {
        public int TankCapacity { get; }
        public double Quantity { get; protected set; }
        
        public virtual double Consumption { get; }
        protected Vehicles(double fuel, double consumption, int tankCapacity )
        {
            if (fuel > tankCapacity)
                this.Quantity = 0;
            else
                this.Quantity = fuel;
            this.Consumption = consumption;
            this.TankCapacity = tankCapacity;
        }
        public void Driving(double distance)
        {
            if (this.Consumption* distance < this.Quantity)
            {
            this.Quantity -= this.Consumption * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km"); 
        }
            else
                Console.WriteLine($"{GetType().Name} needs refueling");
        }


        public virtual void Refueling(double litters)
        {
            if (litters <= 0)
                Console.WriteLine("Fuel must be a positive number");
            else
            {
                if (this.Quantity + litters <= this.TankCapacity)
                    this.Quantity += litters;
                else
                    Console.WriteLine($"Cannot fit {litters} fuel in the tank");
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Math.Round(this.Quantity,2,MidpointRounding.AwayFromZero):f2}";
        }
    }
}
