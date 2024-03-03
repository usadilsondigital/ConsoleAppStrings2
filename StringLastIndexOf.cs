using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Reports the zero-based index position of the last occurrence of a specified Unicode character or string
    //within this instance. The method returns -1 if the character or string is not found in this instance
    public class StringLastIndexOf
    {

        public  void TestCase()
        {
            string intro = "Find the last occurrence of a character using different " +
                           "values of StringComparison.";
            string resultFmt = "Comparison: {0,-28} Location: {1,3}";

            // Define a string to search for.
            // U+00c5 = LATIN CAPITAL LETTER A WITH RING ABOVE
            string CapitalAWithRing = "\u00c5";

        }
    }
}
