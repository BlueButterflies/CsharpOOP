using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAdd, IRemove
    {
        public AddRemoveCollection()
        {
            this.Input = new List<string>();
        }

        private List<string> Input { get; }

        public int Add(string index)
        {
            this.Input.Insert(0, index);

            return 0;
        }

        public string Remove()
        {
            string result = this.Input[this.Input.Count - 1];
            this.Input.RemoveAt(this.Input.Count - 1);

            return result;

        }
    }
}
