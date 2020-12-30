using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy
{
    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        private const int addingIndex= 0;
        
        public override int AddItem(string item)
        {
            this.Data.Insert(addingIndex, item);
            return addingIndex;
        }

        public virtual string RemoveItem()
        {
            int lastIndex = this.Data.Count - 1;
            string result = this.Data[lastIndex];
            this.Data.RemoveAt(lastIndex);
            return result;

        }
    }
}
