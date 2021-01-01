using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicles
    {
        private double quantity;
        private readonly double consumption;
        //public Vehicles(double fuel)
        //{
        //    this.quantity = fuel;
        //}
        public abstract void Driving(double distance);
        //{
        //    if (this.consumption * distance < this.quantity)
        //    {
        //        this.quantity -= this.consumption * distance;
        //        Console.WriteLine($"{GetType().Name} travelled {distance} km");
        //    }
        //    else
        //        Console.WriteLine($"{GetType().Name} needs refueling");
        //}


        public abstract void Refueling(double litters);

    }
}
