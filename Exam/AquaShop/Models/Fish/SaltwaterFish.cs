using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class SaltwaterFish:Fish
    {
        public SaltwaterFish(string name, string species, decimal price)
                            :base(name, species, price)
        {
            this._size = 5;
            //Can only live in SaltwaterAquarium!
        }

        public override void Eat()
        {
            this._size += 2;
        }
    }
}
