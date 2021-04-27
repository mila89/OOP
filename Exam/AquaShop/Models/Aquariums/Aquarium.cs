using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string _name;
        private List<IDecoration> _decorations;
        private List<IFish> _fishes;

        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            _decorations = new List<IDecoration>();
            _fishes = new List<IFish>();
        }
        public string Name
        {
            get => this._name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                this._name = value;
            }
            //o	All names are unique
        }


        public int Capacity { get; }

        public int Comfort
        {
            get
            {
                int sum = 0;
                foreach (var dec in this.Decorations)
                {
                    sum += dec.Comfort;
                }
                return sum;
            }
        }

        public ICollection<IDecoration> Decorations { get => this._decorations; }

        public ICollection<IFish> Fish => this._fishes;

        public void AddDecoration(IDecoration decoration)
        {
            // to check if is nesesery to check null
            if (decoration != null)
            {
                this._decorations.Add(decoration);
            }
        }

        public void AddFish(IFish fish)
        {
            if (this.Capacity <= this.Fish.Count)
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
            this._fishes.Add(fish);
        }

        public void Feed()
        {
            foreach (var f in this.Fish)
            {
                f.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{this.Name} ({GetType().Name}):");
            result.Append("Fish: ");
            if (this.Fish.Count == 0)
            {
                result.AppendLine("none");
            }
            else
            {
                foreach (var f in this.Fish)
                {
                    result.Append($"{f.Name}, ");
                }
                result.Remove(result.Length - 2, 2);
                result.AppendLine();
            }
            result.AppendLine($"Decorations: {this.Decorations.Count}");
            result.AppendLine($"Comfort: {this.Comfort}");

            return result.ToString().TrimEnd();
        }

        public bool RemoveFish(IFish fish)
        {
            bool res = false;
            var current_fish = this.Fish.FirstOrDefault(x => x.Name == fish.Name);
            if (current_fish != null)
            {
                res = true;
                this._fishes.Remove(fish);
            }
            return res;
        }
    }
}
