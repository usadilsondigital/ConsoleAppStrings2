using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a new string in which a specified string is inserted at a specified index position in this instance.
    public class StringInsert
    {
        public  void TestCase()
        {
            String original = "aaabbb";
            Console.WriteLine("The original string: '{0}'", original);
            String modified = original.Insert(3, " ");
            Console.WriteLine("The modified string: '{0}'", modified);
            // The example displays the following output:
            //     The original string: 'aaabbb'
            //     The modified string: 'aaa bbb'
        }

    }
}
