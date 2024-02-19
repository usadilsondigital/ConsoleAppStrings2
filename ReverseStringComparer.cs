using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    public class ReverseStringComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            string? s1 = x as string;
            string? s2 = y as string;
            //negate the return value to get the reverse order
            return -String.Compare(s1, s2);
        }

    }
}
