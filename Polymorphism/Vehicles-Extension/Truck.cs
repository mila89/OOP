using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles_Extension
{
    public class Truck : Vehicles
    {
        public override  double Consumption 
        {
            get { return base.Consumption + 1.6; }
        }
        public Truck(double quantity, double consumption, int tunkCapacity):base(quantity, consumption, tunkCapacity)
        {
        }


        public override void Refueling(double litters)
        {
            if (this.Quantity + litters * 0.95 <= this.TankCapacity)
                base.Refueling(litters * 0.95);
            else
                Console.WriteLine($"Cannot fit {litters} fuel in the tank");
            }
        }
}
