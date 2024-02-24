using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Determines whether this instance and a specified object, which must also be a String object, have the same value.
    public class StringEquals
    {


        public void StringEqualsTest() {
            StringBuilder sb = new StringBuilder("abcd");
            String str1 = "abcd";
            String str2 = null;
            Object o2 = null;
            Console.WriteLine();
            Console.WriteLine(" *  The value of String str1 is '{0}'.", str1);
            Console.WriteLine(" *  The value of StringBuilder sb is '{0}'.", sb.ToString());

            Console.WriteLine();
            Console.WriteLine("1a) String.Equals(Object). Object is a StringBuilder, not a String.");
            Console.WriteLine("    Is str1 equal to sb?: {0}", str1.Equals(sb));

            Console.WriteLine();
            Console.WriteLine("1b) String.Equals(Object). Object is a String.");
            str2 = sb.ToString();
            o2 = str2;

            Console.WriteLine(" *  The value of Object o2 is '{0}'.", o2);
            Console.WriteLine("    Is str1 equal to o2?: {0}", str1.Equals(o2));

            Console.WriteLine();
            Console.WriteLine(" 2) String.Equals(String)");
            Console.WriteLine(" *  The value of String str2 is '{0}'.", str2);
            Console.WriteLine("    Is str1 equal to str2?: {0}", str1.Equals(str2));
        }


    }
}
