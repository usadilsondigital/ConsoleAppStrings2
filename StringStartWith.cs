using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{

    //Determines whether the beginning of this string instance matches the specified string when compared using the specified culture.
    public class StringStartWith
    {
        public  void TestCase()
        {
            string msg1 = "Search for the target string \"{0}\" in the string \"{1}\".\n";
            string msg2 = "Using the {0} - \"{1}\" culture:";
            string msg3 = "  The string to search ends with the target string: {0}";
            bool result = false;
            CultureInfo ci;
            // Define a target string to search for.
            // U+00c5 = LATIN CAPITAL LETTER A WITH RING ABOVE
                string capitalARing = "\u00c5";

                // Define a string to search. 
                // The result of combining the characters LATIN SMALL LETTER A and COMBINING 
                // RING ABOVE (U+0061, U+030a) is linguistically equivalent to the character 
                // LATIN SMALL LETTER A WITH RING ABOVE (U+00e5).
                string aRingXYZ = "\u0061\u030a" + "xyz";

            // Clear the screen and display an introduction.
            Console.Clear();

            // Display the string to search for and the string to search.
            Console.WriteLine(msg1, capitalARing, aRingXYZ);

            // Search using English-United States culture.
            ci = new CultureInfo("en-US");
            Console.WriteLine(msg2, ci.DisplayName, ci.Name);

            Console.WriteLine("Case sensitive:");
            result = aRingXYZ.StartsWith(capitalARing, false, ci);
            Console.WriteLine(msg3, result);

            Console.WriteLine("Case insensitive:");
            result = aRingXYZ.StartsWith(capitalARing, true, ci);
            Console.WriteLine(msg3, result);
            Console.WriteLine();

            // Search using Swedish-Sweden culture.
            ci = new CultureInfo("sv-SE");
            Console.WriteLine(msg2, ci.DisplayName, ci.Name);

            Console.WriteLine("Case sensitive:");
            result = aRingXYZ.StartsWith(capitalARing, false, ci);
            Console.WriteLine(msg3, result);

            Console.WriteLine("Case insensitive:");
            result = aRingXYZ.StartsWith(capitalARing, true, ci);
            Console.WriteLine(msg3, result);

            /*
                Note: This code example was executed on a console whose user interface 
            culture is "en-US" (English-United States).

            Search for the target string "Å" in the string "a°xyz".

            Using the English (United States) - "en-US" culture:
            Case sensitive:
              The string to search ends with the target string: False
            Case insensitive:
              The string to search ends with the target string: True

            Using the Swedish (Sweden) - "sv-SE" culture:
            Case sensitive:
              The string to search ends with the target string: False
            Case insensitive:
              The string to search ends with the target string: False

            */

        }

        public void TestCase2()
        {
            String title = "The House of the Seven Gables";
            String searchString = "the";
            StringComparison comparison = StringComparison.InvariantCulture;
            Console.WriteLine("'{0}':", title);
            Console.WriteLine("   Starts with '{0}' ({1:G} comparison): {2}",searchString, comparison,
                              title.StartsWith(searchString, comparison));
            comparison = StringComparison.InvariantCultureIgnoreCase;
            Console.WriteLine("   Starts with '{0}' ({1:G} comparison): {2}",
                              searchString, comparison,
                              title.StartsWith(searchString, comparison));
            // The example displays the following output:
            //       'The House of the Seven Gables':
            //          Starts with 'the' (InvariantCulture comparison): False
            //          Starts with 'the' (InvariantCultureIgnoreCase comparison): True
        }

        //remove HTML start tags from the beginning of a string.
        public void StripStartTags()
        {
            string[] strSource = { "<b>This is bold text</b>", "<H1>This is large Text</H1>",
                "<b><i><font color=green>This has multiple tags</font></i></b>",
                "<b>This has <i>embedded</i> tags.</b>",
                "<This line simply begins with a lesser than symbol, it should not be modified" };

        }


    }
}
