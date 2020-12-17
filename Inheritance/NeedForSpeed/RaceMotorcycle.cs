using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle:Motorcycle
    {
        
        public RaceMotorcycle(int horsePower, double fuel):base(horsePower,fuel)
        {
            this.DefaultFuelConsumption = 8;
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption; set => base.FuelConsumption = value;
        }

        public override void Drive(double kilometers)
        {
            this.Fuel -= this.FuelConsumption * kilometers;
        }
    }
}
