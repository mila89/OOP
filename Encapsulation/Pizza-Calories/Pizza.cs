using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppingsList;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppingsList = new List<Topping>();
           // this.Dough=new Dough();
        }
        public string Name
        {
            get
            { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length > 15)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                this.name = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough=value; } 
        }
        public double Calories
        {
            get { return CalcCalories(); }
        }

        private double CalcCalories()
        {
            double result = 0;
            for (int i = 0; i < this.Toppings.Count; i++)
            {
                result += this.Toppings[i].Calories;
            }
            result += this.Dough.Calories;
            return result;
        }

        public List<Topping> Toppings
        {
            get {
                if (this.toppingsList.Count>10)
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                return this.toppingsList; }
        }

        public void AddTopping(string name, int weight)
        {
            this.toppingsList.Add(new Topping(name, weight));
        }
    }
}