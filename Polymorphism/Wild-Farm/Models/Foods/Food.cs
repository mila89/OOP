using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Foods
{
    public abstract class Food : Interfaces.IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; }
    }
}
