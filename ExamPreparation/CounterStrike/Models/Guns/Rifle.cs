using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun
    {
        private int bulletsAtFire = 10;
        public Rifle(string name, int bullets) : base(name, bullets)
        {
        }
        public override int Fire()
        {
            if (this.BulletsCount - bulletsAtFire >= 0)
            {
                this.BulletsCount-=bulletsAtFire;
            }
            else
            {
                bulletsAtFire = BulletsCount;
                this.BulletsCount = 0;
            }
            return bulletsAtFire;
        }
    }
}
