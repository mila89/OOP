﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicles
    {
        private double quantity;
        private readonly double consumption;
         public Truck(double quantity, double consumption)
        {
            this.quantity = quantity;
            this.consumption=consumption+ 1.6;
        }

        public double Quantity { get => this.quantity; }
        //public override void Driving(double kilometers)
        //{

        //}

        public override void Refueling(double litters)
        {
            this.quantity += litters*0.95;
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
    }
}
