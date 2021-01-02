using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicles
    {
 
        public override double Consumption 
        { get
            { return base.Consumption + 0.9;
            }
        }
           
        public Car(double quantity, double consumption):base(quantity, consumption)
        {
        }

    }
}
