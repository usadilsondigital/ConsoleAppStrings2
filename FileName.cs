using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    public class FileName : IComparable
    {
        private readonly StringComparer _comparer;

        public string Name { get; }

        public FileName(string name, StringComparer? comparer)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));

            Name = name;

           
        }


        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
