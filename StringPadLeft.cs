using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a new string of a specified length in which the beginning of the current string
    //is padded with spaces or with a specified Unicode character.
    public class StringPadLeft
    {
        public void TestCase() {
            string str = "BBQ and Slaw";
            Console.WriteLine(str.PadLeft(15));  // Displays "   BBQ and Slaw".
            Console.WriteLine(str.PadLeft(5));   // Displays "BBQ and Slaw".
        }

        public  void TestCase2()
        {
            string str = "forty-two";
            char pad = '.';

            Console.WriteLine(str.PadLeft(15, pad));
            Console.WriteLine(str.PadLeft(2, pad));
            // The example displays the following output:
            //       ......forty-two
            //       forty-two
        }
    }
}
