using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    public class StringGetTypeCode
    {

        public static void TestCase()
        {
            String str = "abc";
            TypeCode tc = str.GetTypeCode();
            Console.WriteLine("The type code for '{0}' is {1}, which represents {2}.",str, tc.ToString("D"), tc.ToString("F"));
        }
    }
}
