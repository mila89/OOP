using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy
{
    public interface IAddRemoveCollection:IAddCollection
    {
         string RemoveItem();
    }
}
