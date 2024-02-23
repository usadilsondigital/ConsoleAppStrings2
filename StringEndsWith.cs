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
            String[] strings = { "This is a string.", "Hello!", "Nothing.","Yes.", "randomize" };
            foreach (var value in strings)
            {
                bool endsInPeriod = value.EndsWith(".");
                Console.WriteLine("'{0}' ends in a period: {1}",value, endsInPeriod);
            }
            // The example displays the following output:
            //       'This is a string.' ends in a period: True
            //       'Hello!' ends in a period: False
            //       'Nothing.' ends in a period: True
            //       'Yes.' ends in a period: True
            //       'randomize' ends in a period: False

        }


        public void FileHtmlTags() {
            string[] strSource = { "<b>This is bold text</b>", "<H1>This is large Text</H1>",
                "<b><i><font color=green>This has multiple tags</font></i></b>","<b>This has <i>embedded</i> tags.</b>",
                "This line simply ends with a greater than symbol, it should not be modified>" };

            Console.WriteLine("The following lists the items before the ends have been stripped:");
            Console.WriteLine("-----------------------------------------------------------------");
            // print out the initial array of strings
            foreach (string s in strSource)
                Console.WriteLine(s);

            Console.WriteLine();


        }

    }
}
