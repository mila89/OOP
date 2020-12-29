using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public interface IEngineer:ISpecialisedSoldier
    {
        ICollection<Repair> RepairsList { get; }
    }
}
