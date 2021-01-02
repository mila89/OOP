using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_Extension
{
    public class Bus:Vehicles
    {
        public override double Consumption => base.Consumption+1.4;
        public Bus(double quantity, double consumption, int capacity) : base(quantity, consumption, capacity)
        {

        }
        public void DriveEmpty(double distance)
        {
            if (base.Consumption * distance < this.Quantity)
            {
                this.Quantity -= base.Consumption * distance;
                Console.WriteLine($"{GetType().Name} travelled {distance} km");
            }
            else
                Console.WriteLine($"{GetType().Name} needs refueling");
        }
    }
}
