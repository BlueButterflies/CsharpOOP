using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IAdd, IRemove, IUsed
    {
        public MyList()
        {
            this.Input = new List<string>();
        }

        private List<string> Input { get; }

        public int Used => this.Input.Count;

        public int Add(string index)
        {
            this.Input.Insert(0, index);

            return 0;
        }

        public string Remove()
        {
            string result = this.Input[0];
            this.Input.RemoveAt(0);

            return result;
        }
    }
}
