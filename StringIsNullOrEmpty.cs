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
        String Test(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "is null or empty";
            else
                return String.Format("(\"{0}\") is neither null nor empty", s);
        }

        public void IsNullOrWhiteSpace()
        {
            string[] values = { null, String.Empty, "ABCDE",
                          new String(' ', 20), "  \t   ",
                          new String('\u2000', 10) };
            foreach (string value in values)
                Console.WriteLine(String.IsNullOrWhiteSpace(value));
        }


    }
}
