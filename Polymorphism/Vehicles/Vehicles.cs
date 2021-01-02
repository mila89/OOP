using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicles
    {
        public double Quantity { get; protected set; }
        public virtual double Consumption { get; }
        protected Vehicles(double fuel, double consumption)
        {
            this.Quantity = fuel;
            this.Consumption = consumption;
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
            this.Quantity += litters;
        }

    }
}
