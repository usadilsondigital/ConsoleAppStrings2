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

            // This example produces the following output:
            // Original string: "1 2 3 4 5 6 7 8 9"
            // CSV string:      "1,2,3,4,5,6,7,8,9"
        }

        public void TestCase2() {
            String s = new String('a', 3);
            Console.WriteLine("The initial string: '{0}'", s);
            s = s.Replace('a', 'b').Replace('b', 'c').Replace('c', 'd');
            Console.WriteLine("The final string: '{0}'", s);

            // The example displays the following output:
            //       The initial string: 'aaa'
            //       The final string: 'ddd'
        }

        public void TestCase3()
        {

            string errString = "This docment uses 3 other docments to docment the docmentation";

            Console.WriteLine("The original string is:{0}'{1}'{0}", Environment.NewLine, errString);

            // Correct the spelling of "document".

            string correctString = errString.Replace("docment", "document");

            Console.WriteLine("After correcting the string, the result is:{0}'{1}'",
                    Environment.NewLine, correctString);

            
        }



    }
    }
