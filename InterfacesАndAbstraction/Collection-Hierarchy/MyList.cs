using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy
{
    public class MyList : AddRemoveCollection, IMyList
    {
        public int Used 
        {
            get
            {
                return this.Data.Count;
            }
        }

        public override string RemoveItem()
        {
            string item = this.Data[0];
            this.Data.RemoveAt(0);
            return item;
        }
    }
}
