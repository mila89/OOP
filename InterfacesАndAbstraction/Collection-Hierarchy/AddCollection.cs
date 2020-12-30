using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Hierarchy
{
    public class AddCollection : IAddCollection
    {
        public AddCollection()
        {
            this.Data = new List<string>();
        }

        public List<string> Data { get; set; }
        public virtual int AddItem(string item)
        {
            this.Data.Add(item);
            return this.Data.Count - 1;
        }
    }
}
