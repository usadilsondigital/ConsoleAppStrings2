using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Reports the zero-based index position of the last occurrence in this instance of one or more characters
    //specified in a Unicode array. The method returns -1 if the characters in the array are not found in this instance.
    public class StringLastIndexOfAny
    {
        public void TestCase()
        {

            string br1 = "0----+----1----+----2----+----3----+----4----+----5----+----6----+-";
            string br2 = "0123456789012345678901234567890123456789012345678901234567890123456";
            string str = "Now is the time for all good men to come to the aid of their party.";
            int start;
            int at;
            string target = "is";
            char[] anyOf = target.ToCharArray();
            start = str.Length - 1;
            Console.WriteLine("The last character occurrence  from position {0} to 0.", start);
            Console.WriteLine("{1}{0}{2}{0}{3}{0}", Environment.NewLine, br1, br2, str);
            Console.Write("A character in '{0}' occurs at position: ", target);

            at = str.LastIndexOfAny(anyOf);
            if (at > -1)
                Console.Write(at);
            else
                Console.Write("(not found)");
            Console.Write("{0}{0}{0}", Environment.NewLine);
        }


        public void TestCase2()
        {

            string br1 = "0----+----1----+----2----+----3----+----4----+----5----+----6----+-";
            string br2 = "0123456789012345678901234567890123456789012345678901234567890123456";
            string str = "Now is the time for all good men to come to the aid of their party.";
            int start;
            int at;
            int count;
            string target = "aid";
            char[] anyOf = target.ToCharArray();
            start = ((str.Length - 1) * 2) / 3;
            count = (str.Length - 1) / 3;
            Console.WriteLine("The last character occurrence from position {0} for {1} characters.", start, count);
            Console.WriteLine("{1}{0}{2}{0}{3}{0}", Environment.NewLine, br1, br2, str);
            Console.Write("A character in '{0}' occurs at position: ", target);
            at = str.LastIndexOfAny(anyOf, start, count);
            if (at > -1)
                Console.Write(at);
            else
                Console.Write("(not found)");
            Console.Write("{0}{0}{0}", Environment.NewLine);
            /*
                This example produces the following results:
                The last character occurrence from position 44 for 22 characters.
                0----+----1----+----2----+----3----+----4----+----5----+----6----+-
                0123456789012345678901234567890123456789012345678901234567890123456
                Now is the time for all good men to come to the aid of their party.

                A character in 'aid' occurs at position: 27
                */
        }


    }
    }
