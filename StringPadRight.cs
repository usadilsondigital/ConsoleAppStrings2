﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a new string of a specified length in which the end of the current string
    //is padded with spaces or with a specified Unicode character.
    public class StringPadRight
    {
        public void TestCase() {
            string str;
            str = "BBQ and Slaw";

            Console.Write("|");
            Console.Write(str.PadRight(15));
            Console.WriteLine("|");       // Displays "|BBQ and Slaw   |".

            Console.Write("|");
            Console.Write(str.PadRight(5));
            Console.WriteLine("|");       // Displays "|BBQ and Slaw|".
        }

        public void TestCase2()
        {

            string str = "forty-two";
            char pad = '.';

            Console.WriteLine(str.PadRight(15, pad));    // Displays "forty-two......".
            Console.WriteLine(str.PadRight(2, pad));    // Displays "forty-two".
        }



    }
}
