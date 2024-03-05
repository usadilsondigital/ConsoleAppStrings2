using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a new string in which a specified number of characters from the current string are deleted.
    public class StringRemove
    {
        public  void TestCase()
        {
            string s = "abc---def";

            Console.WriteLine("Index: 012345678");
            Console.WriteLine("1)     {0}", s);
            Console.WriteLine("2)     {0}", s.Remove(3));
            Console.WriteLine("3)     {0}", s.Remove(3, 3));
            /*
            This example produces the following results:

            Index: 012345678
            1)     abc---def
            2)     abc
            3)     abcdef

            */
        }

    }
}
