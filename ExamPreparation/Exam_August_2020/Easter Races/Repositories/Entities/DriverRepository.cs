using EasterRaces.Models.Drivers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class DriverRepository : Repository<IDriver>
    {
        protected override Func<IDriver, bool> FindByNameDelegate(string name)
        {
            return x => x.Name == name;
        }

        protected override string GetNullNameValidationMessage()
        {
            return "Driver cannot be null.";
        }
    }
}
