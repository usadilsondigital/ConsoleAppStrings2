﻿using System;
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

        public void CompareAndDisplay(string Comparand)
        {
            String Lower = "abcd";

            Console.WriteLine(
                "\"{0}\" == \"{1}\" ?  {2}",
                Lower, Comparand, Lower == Comparand);
        }
        /*
        This example of the String Equality operator 
        generates the following output.

        "abcd" == "ijkl" ?  False
        "abcd" == "ABCD" ?  False
        "abcd" == "abcd" ?  True
        */


    }
}
