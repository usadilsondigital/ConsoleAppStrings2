using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a copy of this string converted to lowercase.
    public class StringToLower
    {
        public void TestCase()
        {

            string[] info = { "Name", "Title", "Age", "Location", "Gender" };

            Console.WriteLine("The initial values in the array are:");
            foreach (string s in info)
                Console.WriteLine(s);

            Console.WriteLine("{0}The lowercase of these values is:", Environment.NewLine);

            foreach (string s in info)
                Console.WriteLine(s.ToLower());

            Console.WriteLine("{0}The uppercase of these values is:", Environment.NewLine);

            foreach (string s in info)
                Console.WriteLine(s.ToUpper());
            // The example displays the following output:
            //       The initial values in the array are:
            //       Name
            //       Title
            //       Age
            //       Location
            //       Gender
            //
            //       The lowercase of these values is:
            //       name
            //       title
            //       age
            //       location
            //       gender
            //
            //       The uppercase of these values is:
            //       NAME
            //       TITLE
            //       AGE
            //       LOCATION
            //       GENDER

        }


        public void TestCase2()
        {

            String str1 = "INDIGO";
            // str2 = str1, except each 'I' is '\u0130' (Unicode LATIN CAPITAL I WITH DOT ABOVE).
            String str2 = new String(new Char[] { '\u0130', 'N', 'D', '\u0130', 'G', 'O' });
            String str3, str4;
        }
    }
}
