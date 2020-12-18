using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough()
        {

        }
        public Dough(string flourType, string backingT, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = backingT;
            this.Weight = weight;
        }
        private string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set
            {
                ValidateData("bakingTechnique", value);
                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            get { return this.weight; }
            set
            {
                ValidateData("weight", value.ToString());
                this.weight = value;
            }
        }
        private string FlourType
        {
            get { return this.flourType; }

            set
            {
                ValidateData("flourtype", value);
                this.flourType = value;
            }

        }
        public double Calories
        {
            get
            {
                return 2 * this.weight * TakeCalories(flourType, bakingTechnique);
            }
        }

        private void ValidateData(string type, string value)
        {
            if (type == "bakingTechnique")
            {
                string tempValue = value.ToLower();
                if (!(tempValue == "crispy" || tempValue == "chewy" || tempValue == "homemade"))
                    throw new ArgumentException("Invalid type of dough.");
            }
            if (type == "flourtype")
            {
                string tempValue = value.ToLower();
                if (!(tempValue == "white" || tempValue == "wholegrain"))
                    throw new ArgumentException("Invalid type of dough.");
            }
            if (type == "weight")
                if (int.Parse(value) <1 || int.Parse(value) > 200)
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
        }
        private double TakeCalories(string flourType, string bakingTechnique)
        {
            double flourCal = 0;
            double bakingCal = 0;
            flourType = flourType.ToLower();
            bakingTechnique = bakingTechnique.ToLower();
            if (flourType == "white")
                flourCal = 1.5;
            else 
                flourCal = 1;
            if (bakingTechnique == "crispy")
                bakingCal = 0.9;
            else if (bakingTechnique == "chewy")
                bakingCal = 1.1;
            else
                bakingCal = 1;
            return flourCal * bakingCal;
        }
    }
}
