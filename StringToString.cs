using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    public class StringToString
    {
        public  void TestCase()
        {
            String str1 = "123";
            String str2 = "abc";

            Console.WriteLine("Original str1: {0}", str1);
            Console.WriteLine("Original str2: {0}", str2);
            Console.WriteLine("str1 same as str2?: {0}", Object.ReferenceEquals(str1, str2));
            str2 = str1.ToString();
            Console.WriteLine();
            Console.WriteLine("New str2:      {0}", str2);
            Console.WriteLine("str1 same as str2?: {0}", Object.ReferenceEquals(str1, str2));

        }
    }
}
