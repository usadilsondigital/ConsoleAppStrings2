using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Reports the zero-based index position of the last occurrence of a specified Unicode character or string
    //within this instance. The method returns -1 if the character or string is not found in this instance
    public class StringLastIndexOf
    {

        public  void TestCase()
        {
            string intro = "Find the last occurrence of a character using different " +
                           "values of StringComparison.";
            string resultFmt = "Comparison: {0,-28} Location: {1,3}";

            // Define a string to search for.
            // U+00c5 = LATIN CAPITAL LETTER A WITH RING ABOVE
            string CapitalAWithRing = "\u00c5";


            // Define a string to search. 
            // The result of combining the characters LATIN SMALL LETTER A and COMBINING 
            // RING ABOVE (U+0061, U+030a) is linguistically equivalent to the character 
            // LATIN SMALL LETTER A WITH RING ABOVE (U+00e5).
            string cat = "A Cheshire c" + "\u0061\u030a" + "t";
            int loc = 0;
            StringComparison[] scValues = {
        StringComparison.CurrentCulture,
        StringComparison.CurrentCultureIgnoreCase,
        StringComparison.InvariantCulture,
        StringComparison.InvariantCultureIgnoreCase,
        StringComparison.Ordinal,
        StringComparison.OrdinalIgnoreCase };

            // Clear the screen and display an introduction.
            Console.Clear();
            Console.WriteLine(intro);

            // Display the current culture because culture affects the result. For example, 
            // try this code example with the "sv-SE" (Swedish-Sweden) culture.

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("The current culture is \"{0}\" - {1}.",
                               Thread.CurrentThread.CurrentCulture.Name,
                               Thread.CurrentThread.CurrentCulture.DisplayName);


            // Display the string to search for and the string to search.
            Console.WriteLine("Search for the string \"{0}\" in the string \"{1}\"",
                               CapitalAWithRing, cat);
            Console.WriteLine();

            Console.WriteLine("Part 1: Start index and count are specified.");
            foreach (StringComparison sc in scValues)
            {
                loc = cat.LastIndexOf(CapitalAWithRing, cat.Length - 1, cat.Length, sc);
                Console.WriteLine(resultFmt, sc, loc);
            }


        }
    }
}
