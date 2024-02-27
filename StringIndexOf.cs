using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    public class StringIndexOf
    {
        public void TestCase() {
            string br1 = "0----+----1----+----2----+----3----+----4----+----5----+----6----+---";
            string br2 = "012345678901234567890123456789012345678901234567890123456789012345678";
            string str = "Now is the time for all good men to come to the aid of their country.";
            int start;
            int at;
            int end;
            int count;
            end = str.Length;
            start = end / 2;
            Console.WriteLine();
            Console.WriteLine("All occurrences of 'he' from position {0} to {1}.", start, end - 1);
            Console.WriteLine("{1}{0}{2}{0}{3}{0}", Environment.NewLine, br1, br2, str);
            Console.Write("The string 'he' occurs at position(s): ");
            count = 0;
            at = 0;
            while ((start <= end) && (at > -1))
            {
                // start+count must be a position within -str-.
                count = end - start;
                at = str.IndexOf("he", start, count);
                if (at == -1) break;
                Console.Write("{0} ", at);
                start = at + 1;
            }
        }
    }
}
