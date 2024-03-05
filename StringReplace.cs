using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a new string in which all occurrences of a specified Unicode character
    //or String in the current string are replaced with another specified Unicode character or String.
    public class StringReplace
    {

        public void TestCase() {
            String str = "1 2 3 4 5 6 7 8 9";
            Console.WriteLine("Original string: \"{0}\"", str);
            Console.WriteLine("CSV string:      \"{0}\"", str.Replace(' ', ','));

        }
    }
}
