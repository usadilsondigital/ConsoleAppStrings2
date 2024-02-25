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

        public void FormatThree()
        {
            decimal temp = 20.4m;
            string s = String.Format("The temperature is {0}°C.", temp);
            Console.WriteLine(s);
            // Displays 'The temperature is 20.4°C.'
        }

        public void FormatFour()
        {
            string s = String.Format("At {0}, the temperature is {1}°C.",
                         DateTime.Now, 20.4);
            Console.WriteLine(s);
            // Output similar to: 'At 4/10/2015 9:29:41 AM, the temperature is 20.4°C.'
        }

        public void FormatFive()
        {
            string s = String.Format("It is now {0:d} at {0:t}", DateTime.Now);
            Console.WriteLine(s);
            // Output similar to: 'It is now 4/10/2015 at 10:04 AM'
        }

        public string Format2Args() {
            Dictionary<DateTime, Double> temperatureInfo = new Dictionary<DateTime, Double>();
            temperatureInfo.Add(new DateTime(2010, 6, 1, 14, 0, 0), 87.46);
            temperatureInfo.Add(new DateTime(2010, 12, 1, 10, 0, 0), 36.81);
            Console.WriteLine("Temperature Information:\n");
            string output;
            foreach (var item in temperatureInfo)
            {
                output = String.Format("Temperature at {0,8:t} on {0,9:d}: {1,5:N1}°F",
                                       item.Key, item.Value);
                Console.WriteLine(output);
            }
            // The example displays output like the following:
            //       Temperature Information:
            //       
            //       Temperature at  2:00 PM on  6/1/2010:  87.5°F
            //       Temperature at 10:00 AM on 12/1/2010:  36.8°F


        }




    }
    }
