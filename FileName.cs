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
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
