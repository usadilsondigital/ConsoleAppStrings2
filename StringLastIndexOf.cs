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

        public void TestCase()
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


            // Note that in each of the following searches, we look for 
            // LATIN CAPITAL LETTER A WITH RING ABOVE in a string that contains 
            // LATIN SMALL LETTER A WITH RING ABOVE. A result value of -1 indicates 
            // the string was not found.
            // Search using different values of StringComparsion. Specify the start 
            // index and count. 
            Console.WriteLine("Part 1: Start index and count are specified.");
            foreach (StringComparison sc in scValues)
            {
                loc = cat.LastIndexOf(CapitalAWithRing, cat.Length - 1, cat.Length, sc);
                Console.WriteLine(resultFmt, sc, loc);
            }
            // Search using different values of StringComparsion. Specify the 
            // start index. 
            Console.WriteLine("\nPart 2: Start index is specified.");
            foreach (StringComparison sc in scValues)
            {
                loc = cat.LastIndexOf(CapitalAWithRing, cat.Length - 1, sc);
                Console.WriteLine(resultFmt, sc, loc);
            }

            // Search using different values of StringComparsion. 
            Console.WriteLine("\nPart 3: Neither start index nor count is specified.");
            foreach (StringComparison sc in scValues)
            {
                loc = cat.LastIndexOf(CapitalAWithRing, sc);
                Console.WriteLine(resultFmt, sc, loc);
            }

            /*
            Note: This code example was executed on a console whose user interface 
            culture is "en-US" (English-United States).

            This code example produces the following results:

            Find the last occurrence of a character using different values of StringComparison.
            The current culture is "en-US" - English (United States).
            Search for the string "Å" in the string "A Cheshire ca°t"

            Part 1: Start index and count are specified.
            Comparison: CurrentCulture               Location:  -1
            Comparison: CurrentCultureIgnoreCase     Location:  12
            Comparison: InvariantCulture             Location:  -1
            Comparison: InvariantCultureIgnoreCase   Location:  12
            Comparison: Ordinal                      Location:  -1
            Comparison: OrdinalIgnoreCase            Location:  -1

            Part 2: Start index is specified.
            Comparison: CurrentCulture               Location:  -1
            Comparison: CurrentCultureIgnoreCase     Location:  12
            Comparison: InvariantCulture             Location:  -1
            Comparison: InvariantCultureIgnoreCase   Location:  12
            Comparison: Ordinal                      Location:  -1
            Comparison: OrdinalIgnoreCase            Location:  -1

            Part 3: Neither start index nor count is specified.
            Comparison: CurrentCulture               Location:  -1
            Comparison: CurrentCultureIgnoreCase     Location:  12
            Comparison: InvariantCulture             Location:  -1
            Comparison: InvariantCultureIgnoreCase   Location:  12
            Comparison: Ordinal                      Location:  -1
            Comparison: OrdinalIgnoreCase            Location:  -1

            */
        }


        public void TestCase2() {
            string searchString = "\u00ADm";

            string s1 = "ani\u00ADmal";
            string s2 = "animal";

            int position;
            position = s1.LastIndexOf('m');
            if (position >= 1)
            {
                Console.WriteLine(s1.LastIndexOf(searchString, position, position, StringComparison.CurrentCulture));
                Console.WriteLine(s1.LastIndexOf(searchString, position, position, StringComparison.Ordinal));
            }
            position = s2.LastIndexOf('m');
            if (position >= 1)
            {
                Console.WriteLine(s2.LastIndexOf(searchString, position, position, StringComparison.CurrentCulture));
                Console.WriteLine(s2.LastIndexOf(searchString, position, position, StringComparison.Ordinal));
            }
            // The example displays the following output:
            //
            // 4
            // 3
            // 3
            // -1
        }


    }
}
