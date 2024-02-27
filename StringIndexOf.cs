using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{

    //Reports the zero-based index of the first occurrence of a specified Unicode character or string within this instance.
    //The method returns -1 if the character or string is not found in this instance.
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
            Console.WriteLine();

            /*
            This example produces the following results:
            All occurrences of 'he' from position 34 to 68.
                0----+----1----+----2----+----3----+----4----+----5----+----6----+---
                012345678901234567890123456789012345678901234567890123456789012345678
                Now is the time for all good men to come to the aid of their country.

                The string 'he' occurs at position(s): 45 56

                */

        }


        public  void TestCase2()
        {
            string searchString = "\u00ADm";
            string s1 = "ani\u00ADmal";
            string s2 = "animal";

            Console.WriteLine(s1.IndexOf(searchString, 2, 4));
            Console.WriteLine(s2.IndexOf(searchString, 2, 4));

            // The example displays the following output:
            //       4
            //       3
        }


        public void TestCulture() {
            string searchString = "\u00ADm";
            string s1 = "ani\u00ADmal";
            string s2 = "animal";
        }

    }
}
