using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public abstract class Player : IPlayer
    {
        private string _username;
        private int _health;
        private int _armor;
        private bool _isAlive;
        private IGun _gun;

        public Player(string username, int health, int armor, IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }
        public string Username
        {
            get { return this._username; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }
                this._username = value;
            }
        }


        public int Health
        {
            get { return this._health; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                this._health = value;
            }
        }

        public int Armor
        {
            get { return this._armor; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                this._armor = value;
            }

        }

        public IGun Gun {
            get { return this._gun; }
            private set 
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunName);
                }
                this._gun = value;
            }
        }

        public bool IsAlive
        {
            get { return this.Health > 0; }

        }


        public void TakeDamage(int points)
        {
            if (this._armor - points > 0)
            {
                this._armor -= points;
            }
            else
            {
                this._health =this._health+ this._armor - points;
                this._armor = 0;
            }
         }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}: {this.Username}");
            sb.AppendLine($"--Health: {this.Health}");
            sb.AppendLine($"--Armor: {this.Armor}");
            sb.AppendLine($"--Gun: {this.Gun.Name}");

            return sb.ToString().TrimEnd();
        }
    }
}
