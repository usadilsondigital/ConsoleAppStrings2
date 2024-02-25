using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Converts the value of objects to strings based on the formats specified and inserts them into another string.
    public class StringFormat
    {

        //Use String.Format if you need to insert the value of an object, variable, or expression into another string.
        //For example, you can insert the value of a Decimal value into a string to display it to the user as a single string:

        public void FormatOne() {

            Decimal pricePerOunce = 17.36m;
            String s = String.Format("The current price is {0} per ounce.",
                                     pricePerOunce);
            Console.WriteLine(s);
            // Result: The current price is 17.36 per ounce.
            }
        public void FormatTwo()
        {
            Decimal pricePerOunce = 17.36m;
            String s = String.Format("The current price is {0:C2} per ounce.",
                                     pricePerOunce);
            Console.WriteLine(s);
            // Result if current culture is en-US:
            //      The current price is $17.36 per ounce.
        }


    }
    }
