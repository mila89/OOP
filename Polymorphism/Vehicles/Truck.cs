using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicles
    {
        public override  double Consumption 
        {
            get { return base.Consumption + 1.6; }
        }
        public Truck(double quantity, double consumption):base(quantity, consumption)
        {
        }


        public override void Refueling(double litters)
        {
            base.Refueling(litters * 0.95);
        }

    }
}
