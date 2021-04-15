using EasterRaces.Models.Races.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class RaceRepository : Repository<IRace>
    {
        protected override Func<IRace, bool> FindByNameDelegate(string name)
        {
            return x => x.Name == name;
        }

        protected override string GetNullNameValidationMessage()
        {
            return "Race cannot be null.";
        }
    }
}
