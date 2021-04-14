using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : Repository<ICar>
    {
        protected override Func<ICar, bool> FindByNameDelegate(string name)
        {
            return x => x.Model == name;
        }

        protected override string GetNullNameValidationMessage()
        {
            return "Car cannot be null.";
        }
    }
}
