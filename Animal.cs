using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    public class Animal
    {
        public string Kind;
        public string Order;

        public Animal(string kind, string order)
        {
            this.Kind = kind;
            this.Order = order;
        }

        public override string ToString()
        {
            return this.Kind;
        }
    }
}
