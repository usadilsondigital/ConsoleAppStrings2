using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Determines whether two specified strings have different values.
    public class StringInequality
    {

        public  void TestCase()
        {
            Console.WriteLine(
                "This example of the String Inequality operator\n" +
                "generates the following output.\n");

            CompareAndDisplay("ijkl");
            CompareAndDisplay("ABCD");
            CompareAndDisplay("abcd");
        }

        public void CompareAndDisplay(String Comparand)
        {
            String Lower = "abcd";

            Console.WriteLine(
                "\"{0}\" != \"{1}\" ?  {2}",
                Lower, Comparand, Lower != Comparand);
        }

        /*
            This example of the String Inequality operator
            generates the following output.

            "abcd" != "ijkl" ?  True
            "abcd" != "ABCD" ?  True
            "abcd" != "abcd" ?  False
            */


    }
}
