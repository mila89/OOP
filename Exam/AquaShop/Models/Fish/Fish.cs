using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public abstract class Fish : IFish
    {
        private string _name;
        private string _spicies;
        private decimal _price;
        protected int _size;

        public Fish(string name, string species, decimal price)
        {
            this.Name = name;
            this.Species = species;
            this.Price = price;
        }
        public string Name
        {
            get => this._name;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Fish name cannot be null or empty.");
                this._name = value;
            }
        }

        public string Species
        { 
            get=> this._spicies;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Fish species cannot be null or empty.");
                this._spicies = value;
            }
        }

        public int Size { get=>this._size; }

        public decimal Price
        {
            get => this._price;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Fish price cannot be below or equal to 0.");
                this._price = value;
            }
        }

        public abstract void Eat();
        
    }
}
