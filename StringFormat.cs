﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public void Format2Args() {
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

        public void CultureFormatting() {
            string[] cultureNames = { "en-US", "fr-FR", "de-DE", "es-ES" };

            DateTime dateToDisplay = new DateTime(2009, 9, 1, 18, 32, 0);
            double value = 9164.32;
            Console.WriteLine("Culture     Date                                Value\n");
            foreach (string cultureName in cultureNames)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo(cultureName);
                string output = String.Format(culture, "{0,-11} {1,-35:D} {2:N}",
                                              culture.Name, dateToDisplay, value);
                Console.WriteLine(output);
            }

            // The example displays the following output:
            //    Culture     Date                                Value
            //    
            //    en-US       Tuesday, September 01, 2009         9,164.32
            //    fr-FR       mardi 1 septembre 2009              9 164,32
            //    de-DE       Dienstag, 1. September 2009         9.164,32
            //    es-ES       martes, 01 de septiembre de 2009    9.164,32
        }

        public void FormatMoreThreeArgs() {
            DateTime date1 = new DateTime(2009, 7, 1);
            TimeSpan hiTime = new TimeSpan(14, 17, 32);
            decimal hiTemp = 62.1m;
            TimeSpan loTime = new TimeSpan(3, 16, 10);
            decimal loTemp = 54.8m;
            string result1 = String.Format("Temperature on {0:d}:\n{1,11}: {2} degrees (hi)\n{3,11}: {4} degrees (lo)",
                               date1, hiTime, hiTemp, loTime, loTemp);
            Console.WriteLine(result1);
            Console.WriteLine();
            string result2 = String.Format("Temperature on {0:d}:\n{1,11}: {2} degrees (hi)\n{3,11}: {4} degrees (lo)",
                               new object[] { date1, hiTime, hiTemp, loTime, loTemp });
            Console.WriteLine(result2);
            // The example displays output like the following:
            //       Temperature on 7/1/2009:
            //          14:17:32: 62.1 degrees (hi)
            //          03:16:10: 54.8 degrees (lo)
            //       Temperature on 7/1/2009:
            //          14:17:32: 62.1 degrees (hi)
            //          03:16:10: 54.8 degrees (lo)

        }

        public static void ShowPopulationData(CityInfo city)
        {
            object[] args = { city.Name, city.Year, city.Population, city.Area };
            String result = String.Format("{0} in {1}: Population {2:N0}, Area {3:N1} sq. feet",
                                          args);
            Console.WriteLine(result);
        }

        public void ShowingCityInfo() {
            CityInfo nyc2010 = new CityInfo("New York", 8175133, 302.64m, 2010);
            ShowPopulationData(nyc2010);
            CityInfo sea2010 = new CityInfo("Seattle", 608660, 83.94m, 2010);
            ShowPopulationData(sea2010);

        }

        public void FormattingSingleArgument() {
            DateTime birthdate = new DateTime(1993, 7, 28);
            DateTime[] dates = { new DateTime(1993, 8, 16),
                     new DateTime(1994, 7, 28),
                     new DateTime(2000, 10, 16),
                     new DateTime(2003, 7, 27),
                     new DateTime(2007, 5, 27) };
            foreach (DateTime dateValue in dates)
            {
                TimeSpan interval = dateValue - birthdate;
                // Get the approximate number of years, without accounting for leap years.

                int years = ((int)interval.TotalDays) / 365;
                // See if adding the number of years exceeds dateValue.
                string output;
                if (birthdate.AddYears(years) <= dateValue)
                {
                    output = String.Format("You are now {0} years old.", years);
                    Console.WriteLine(output);
                }
                else
                {
                    output = String.Format("You are now {0} years old.", years - 1);
                    Console.WriteLine(output);
                }

                // The example displays the following output:
                //       You are now 0 years old.
                //       You are now 1 years old.
                //       You are now 7 years old.
                //       You are now 9 years old.
                //       You are now 13 years old.
            }

        }



}
    }
