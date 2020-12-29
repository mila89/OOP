using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public interface ICommando:ISpecialisedSoldier
    {
        ICollection<IMission> Missions { get; }
    }
}
