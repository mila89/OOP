using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Topping
    {
        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        internal double Calories
        {
            get
            {
                return 2 * this.weight * TakeCalories(this.type);
            }
        }

        internal double TakeCalories(string type)
        {
            type = type.ToLower();
            if (type == "meat")
                return 1.2;
            if (type == "veggies")
                return 0.8;
            if (type == "cheese")
                return 1.1;
            if (type == "sauce")
                return 0.9;
            return 0;
        }

        private string Type
        {
            get { return this.type; }
            set
            {
                ValidateData(value, "type");
                this.type = value;
            }
        }

        private int Weight
        {
            get { return this.weight; }
            set
            {
                ValidateData(value.ToString(),"weight");
                this.weight = value;
            }
        }

        private void ValidateData(string value, string v)
        {
            if (v == "type")
            {
                string tempValue = value.ToLower();
                if (!(tempValue == "meat" || tempValue == "veggies" || tempValue == "cheese" || tempValue == "sauce"))
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            if (v == "weight")
                if (int.Parse(value) < 1 || int.Parse(value) > 50)
                    throw new ArgumentException($"{this.Type} weight should be in the range[1..50].");
        }


    }
}
