using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{

    //Determines whether the end of this string instance matches a specified string.
    public class StringEndsWith
    {
        public void ArrayEndsWithPeriod()
        {
            String[] strings = { "This is a string.", "Hello!", "Nothing.", "Yes.", "randomize" };
            foreach (var value in strings)
            {
                bool endsInPeriod = value.EndsWith(".");
                Console.WriteLine("'{0}' ends in a period: {1}", value, endsInPeriod);
            }
            // The example displays the following output:
            //       'This is a string.' ends in a period: True
            //       'Hello!' ends in a period: False
            //       'Nothing.' ends in a period: True
            //       'Yes.' ends in a period: True
            //       'randomize' ends in a period: False

        }


        public void FileHtmlTags()
        {
            string[] strSource = { "<b>This is bold text</b>", "<H1>This is large Text</H1>",
                "<b><i><font color=green>This has multiple tags</font></i></b>","<b>This has <i>embedded</i> tags.</b>",
                "This line simply ends with a greater than symbol, it should not be modified>" };

            Console.WriteLine("The following lists the items before the ends have been stripped:");
            Console.WriteLine("-----------------------------------------------------------------");
            // print out the initial array of strings
            foreach (string s in strSource)
                Console.WriteLine(s);

            Console.WriteLine();

            Console.WriteLine("The following lists the items after the ends have been stripped:");
            Console.WriteLine("----------------------------------------------------------------");

            // print out the array of strings
            foreach (var s in strSource)
                Console.WriteLine(StripEndTags(s));
        }
        private static string StripEndTags(string item)
        {

            bool found = false;

            // try to find a tag at the end of the line using EndsWith
            if (item.Trim().EndsWith(">"))
            {
                // now search for the opening tag...
                int lastLocation = item.LastIndexOf("</");

                // remove the identified section, if it is a valid region
                if (lastLocation >= 0)
                {
                    found = true;
                    item = item.Substring(0, lastLocation);
                }
            }
            if (found)
                item = StripEndTags(item);
            return item;
        }
        /*output example*/
        // The example displays the following output:
        //    The following lists the items before the ends have been stripped:
        //    -----------------------------------------------------------------
        //    <b>This is bold text</b>
        //    <H1>This is large Text</H1>
        //    <b><i><font color=green>This has multiple tags</font></i></b>
        //    <b>This has <i>embedded</i> tags.</b>
        //    This line simply ends with a greater than symbol, it should not be modified>
        //
        //    The following lists the items after the ends have been stripped:
        //    ----------------------------------------------------------------
        //    <b>This is bold text
        //    <H1>This is large Text
        //    <b><i><font color=green>This has multiple tags
        //    <b>This has <i>embedded</i> tags.
        //    This line simply ends with a greater than symbol, it should not be modified>



        public void ParticularSubstring() {

            string intro = "Determine whether a string ends with another string, " +
                       "using\n  different values of StringComparison.";

            StringComparison[] scValues = {
            StringComparison.CurrentCulture,
            StringComparison.CurrentCultureIgnoreCase,
            StringComparison.InvariantCulture,
            StringComparison.InvariantCultureIgnoreCase,
            StringComparison.Ordinal,
            StringComparison.OrdinalIgnoreCase };

            Console.WriteLine(intro);

            // Display the current culture because the culture-specific comparisons
            // can produce different results with different cultures.
            Console.WriteLine("The current culture is {0}.\n",Thread.CurrentThread.CurrentCulture.Name);

            // Determine whether three versions of the letter I are equal to each other. 
            foreach (StringComparison sc in scValues)
            {
                Console.WriteLine("StringComparison.{0}:", sc);
                Test("abcXYZ", "XYZ", sc);
                Test("abcXYZ", "xyz", sc);
                Console.WriteLine();
            }


        }

        protected static void Test(string x, string y, StringComparison comparison)
        {
            string resultFmt = "\"{0}\" {1} with \"{2}\".";
            string result = "does not end";

            if (x.EndsWith(y, comparison))
                result = "ends";
            Console.WriteLine(resultFmt, x, result, y);
        }


    }
}
