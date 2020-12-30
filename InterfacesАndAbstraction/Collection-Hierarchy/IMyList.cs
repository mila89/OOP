using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy
{
    public interface IMyList:IAddRemoveCollection
    {
        int  Used { get;  }
    }
}
