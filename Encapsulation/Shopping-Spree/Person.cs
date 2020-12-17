using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
    public class Person
    {
        private string name;
        private double money;
        private List<string> bag;

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<string>();
        }
        public string Name
        {
            get { return this.name; }

            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");
                this.name = value;
            }
        }

        public List<string> Bag
        {
            get { return this.bag; }
        }

        
        public double Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Money cannot be negative");
                else
                    this.money = value;
            }

        }

        public void AddInBag(string productName)
        {
            this.bag.Add(productName);
        }
    }
}
