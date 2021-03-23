using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Pistol : Gun
    {
        private int bulletsAtFire = 1;
        public Pistol(string name, int bullets):base(name,bullets)
        {

        }
        public override int Fire()
        {
            if (this.BulletsCount - bulletsAtFire >= 0)
            {
                this.BulletsCount -= bulletsAtFire;
            }
            else
            {
                bulletsAtFire = this.BulletsCount;
                this.BulletsCount = 0;
            }
                return bulletsAtFire;
        }
    }
}
