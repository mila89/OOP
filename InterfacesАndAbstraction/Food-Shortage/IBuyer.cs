using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Shortage
{
    public interface IBuyer
    {
        void BuyFood();
        public string Name { get; set; }
        public int Food { get; set; }
    }
}
