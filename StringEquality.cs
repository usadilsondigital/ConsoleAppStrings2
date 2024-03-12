using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Determines whether two specified strings have the same value.
    public class StringEquality
    {

        public  void TestCase()
        {
            Console.WriteLine("This example of the String Equality operator\n" +
                "generates the following output.\n");

            CompareAndDisplay("ijkl");
            CompareAndDisplay("ABCD");
            CompareAndDisplay("abcd");
        }


    }
}
