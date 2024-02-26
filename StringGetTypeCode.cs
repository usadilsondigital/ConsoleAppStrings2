using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns the TypeCode for the String class.
    public class StringGetTypeCode
    {

        public static void TestCase()
        {
            String str = "abc";
            TypeCode tc = str.GetTypeCode();
            Console.WriteLine("The type code for '{0}' is {1}, which represents {2}.",str, tc.ToString("D"), tc.ToString("F"));
            /*
                This example produces the following results:
                The type code for 'abc' is 18, which represents String.
                */
        }
    }
}
