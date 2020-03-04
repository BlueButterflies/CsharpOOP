using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAdd
    {
        public AddCollection()
        {
            this.Input = new List<string>();
        }

        public List<string> Input { get; }


        public int Add(string index)
        {
           this.Input.Add(index);

           return this.Input.Count - 1;
        }
    }
}
