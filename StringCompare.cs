using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{


    /// <summary>
    /// <0 MEANS The substring in strA precedes the substring in strB in the sort order.  
    /// =0 MEANS The substrings occur in the same position in the sort order, or length is zero.  
    /// >0 MEANS  The substring in strA follows the substring in strB in the sort order. 
    /// </summary>

    Zero

    internal class StringCompare
    {
        public string name1 { get; set; }
        public string name2 { get; set; }

        public StringCompare()
        {
            name1 = string.Empty;
            name2 = string.Empty;
        }

        public StringCompare(string name1,string name2)
        {
            this.name1 = name1 ?? string.Empty;
            this.name2 = name2 ?? string.Empty;
        }

        public void UsingCompare() {
             name1 = "Jack Smith";
             name2 = "John Doe";

            // Get position of character after the space character.
            int index1 = name1.IndexOf(" ");
            index1 = index1 < 0 ? 0 : ++index1;
            int index2 = name2.IndexOf(" ");
            index2 = index2 < 0 ? 0 : ++index2;

            int max_length = Math.Max(name1.Length, name2.Length);

            Console.WriteLine("Sorted alphabetically by last name:");
            if (String.Compare(name1, index1, name2, index2, max_length,
                               new CultureInfo("en-US"), CompareOptions.IgnoreCase) < 0)
                Console.WriteLine("{0}\n{1}", name1, name2);
            else
                Console.WriteLine("{0}\n{1}", name2, name1);

            // The example displays the following output:
            //       Sorted alphabetically by last name:
            //       John Doe
            //       Jack Smith


        }


        public void Compare2Substrings() {

            String str1 = "machine";
            String str2 = "device";
            String str;
            int result;


        }


    }
}
