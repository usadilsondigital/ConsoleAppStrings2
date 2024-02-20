using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    internal class StringContains
    {
        public string s1 { get; set; }
        public string s2 { get; set; }

        public void StringUsingContain() {
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}",s2, s1, b);
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                    Console.WriteLine("'{0} begins at character position {1}",s2, index + 1);
            }
            // This example displays the following output:
            //    'fox' is in the string 'The quick brown fox jumps over the lazy dog': True
            //    'fox begins at character position 17
        }


    }
}
