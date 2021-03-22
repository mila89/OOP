using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string _name;
        private int _bulletsCount;

        public Gun(string name, int bullets)
        {
            this.Name = name;
            this.BulletsCount = bullets;
        }
        public string Name
        {
            get
            { return this._name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunName);
                }
                this._name = value;
            }
        }

        public int BulletsCount
        {
            get { return this._bulletsCount; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunBulletsCount);
                }
                this._bulletsCount = value;
            }
        }

        public abstract int Fire();
        
    }
}
