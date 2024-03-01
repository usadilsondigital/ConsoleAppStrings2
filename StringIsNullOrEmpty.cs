using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Indicates whether the specified string is null or an empty string ("").
    public class StringIsNullOrEmpty
    {
        public void TestCase() {
            string s1 = "abcd";
            string s2 = "";
            string s3 = null;

            Console.WriteLine("String s1 {0}.", Test(s1));
            Console.WriteLine("String s2 {0}.", Test(s2));
            Console.WriteLine("String s3 {0}.", Test(s3));

            
        }
    }
}
