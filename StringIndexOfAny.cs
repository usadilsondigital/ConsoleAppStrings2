using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Reports the index of the first occurrence in this instance of any character in a specified array of Unicode characters.
    //The method returns -1 if the characters in the array are not found in this instance.
    public class StringIndexOfAny
    {
        public  void TestCase()
        {
            char[] chars = { 'a', 'e', 'i', 'o', 'u', 'y','A', 'E', 'I', 'O', 'U', 'Y' };
            String s = "The long and winding road...";
            Console.WriteLine("The first vowel in \n   {0}\nis found at position {1}",
                              s, s.IndexOfAny(chars) + 1);
            // The example displays the following output:
            //       The first vowel in
            //          The long and winding road...
            //       is found at position 3
        }


        //The following example finds the index of the occurrence of any character of the string "is" within a substring of another string.
        public void TestCase2()
        {
            string br1 = "0----+----1----+----2----+----3----+----4----+----5----+----6----+-";
            string br2 = "0123456789012345678901234567890123456789012345678901234567890123456";
            string str = "Now is the time for all good men to come to the aid of their party.";
            int start;
            int at;
            string target = "is";
            char[] anyOf = target.ToCharArray();

            start = str.Length / 2;
            Console.WriteLine();
            Console.WriteLine("The first character occurrence from position {0} to {1}.",
                           start, str.Length - 1);
            Console.WriteLine("{1}{0}{2}{0}{3}{0}", Environment.NewLine, br1, br2, str);
            Console.Write("A character in '{0}' occurs at position: ", target);

            at = str.IndexOfAny(anyOf, start);
            if (at > -1)
                Console.Write(at);
            else
                Console.Write("(not found)");
            Console.WriteLine();
        }
        /*

The first character occurrence from position 33 to 66.
0----+----1----+----2----+----3----+----4----+----5----+----6----+-
0123456789012345678901234567890123456789012345678901234567890123456
Now is the time for all good men to come to the aid of their party.

A character in 'is' occurs at position: 49

*/



        //The following example finds the index of the occurrence of
        //any character of the string "aid" within a substring of another string.
        //Sample for String.IndexOfAny(Char[], Int32, Int32)
        public static void IndexOfAnySubstring()
        {
            string br1 = "0----+----1----+----2----+----3----+----4----+----5----+----6----+-";
            string br2 = "0123456789012345678901234567890123456789012345678901234567890123456";
            string str = "Now is the time for all good men to come to the aid of their party.";
            int start;
            int at;
            int count;
            string target = "aid";
            char[] anyOf = target.ToCharArray();

            start = (str.Length - 1) / 3;
            count = (str.Length - 1) / 4;
            Console.WriteLine();
            Console.WriteLine("The first character occurrence from position {0} for {1} characters.", start, count);
            Console.WriteLine("{1}{0}{2}{0}{3}{0}", Environment.NewLine, br1, br2, str);
            Console.Write("A character in '{0}' occurs at position: ", target);
            at = str.IndexOfAny(anyOf, start, count);
            if (at > -1)
                Console.Write(at);
            else
                Console.Write("(not found)");
            Console.WriteLine();
        }

    }






        }
}
