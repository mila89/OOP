using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicles
    {
        private double quantity;
        private readonly double consumption;

        public double Quantity { get => this.quantity; }
           
        public Car(double quantity, double consumption)
        {
            this.consumption=consumption+0.9;
            this.quantity = quantity;
        }
        public override void Driving(double distance)
        {
            if (this.consumption * distance <= this.quantity)
            {
                this.quantity -= this.consumption * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
                Console.WriteLine($"{GetType().Name} needs refueling");
        }

        public override void Refueling(double litters)
        {
            this.quantity += litters;
        }
    }
}
