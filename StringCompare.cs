using System;
using System.Collections;
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

    ///https://learn.microsoft.com/en-us/dotnet/standard/base-types/best-practices-strings

    internal class StringCompare
    {
        public string name1 { get; set; }
        public string name2 { get; set; }

        public StringCompare()
        {
            name1 = string.Empty;
            name2 = string.Empty;
        }

        public StringCompare(string name1, string name2)
        {
            this.name1 = name1 ?? string.Empty;
            this.name2 = name2 ?? string.Empty;
        }

        public void UsingCompare()
        {
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


        public void Compare2Substrings()
        {

            String str1 = "machine";
            String str2 = "device";
            String str;
            int result;
            Console.WriteLine();
            Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
            result = String.Compare(str1, 2, str2, 0, 2);
            str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(0, 2), str2);
            /*
                This example produces the following results:

                str1 = 'machine', str2 = 'device'
                Substring 'ch' in 'machine' is less than substring 'de' in 'device'.
                */
        }

        public void SortingDiffCultures()
        {
            //Words to sort
            string[] values = { "able", "ångström", "apple", "Æble", "Windows", "Visual Studio" };
            // Current culture
            Array.Sort(values);
            DisplayArray(values);

            // Change culture to Swedish (Sweden)
            string originalCulture = CultureInfo.CurrentCulture.Name;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("sv-SE");
            Array.Sort(values);
            DisplayArray(values);

            // Restore the original culture
            Thread.CurrentThread.CurrentCulture = new CultureInfo(originalCulture);
            // The example displays the following output:
            //     Sorting using the en-US culture:
            //        able
            //        Æble
            //        ångström
            //        apple
            //        Visual Studio
            //        Windows
            //
            //     Sorting using the sv-SE culture:
            //        able
            //        apple
            //        Visual Studio
            //        Windows
            //        ångström
            //        Æble
        }

        public void DisplayArray(string[] values)
        {
            Console.WriteLine($"Sorting using the {CultureInfo.CurrentCulture.Name} culture:");
            foreach (string value in values)
                Console.WriteLine($"   {value}");
            Console.WriteLine();
        }
        public void StringVariantsBetweenCultures()
        {


            string name = "Bill";
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine($"Culture = {Thread.CurrentThread.CurrentCulture.DisplayName}");
            Console.WriteLine($"   Is 'Bill' the same as 'BILL'? {name.Equals("BILL", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"   Does 'Bill' start with 'BILL'? {name.StartsWith("BILL", true, null)}");
            Console.WriteLine();


            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Console.WriteLine($"Culture = {Thread.CurrentThread.CurrentCulture.DisplayName}");
            Console.WriteLine($"   Is 'Bill' the same as 'BILL'? {name.Equals("BILL", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"   Does 'Bill' start with 'BILL'? {name.StartsWith("BILL", true, null)}");


            //' The example displays the following output:
            //'
            //'     Culture = English (United States)
            //'        Is 'Bill' the same as 'BILL'? True
            //'        Does 'Bill' start with 'BILL'? True
            //'     
            //'     Culture = Turkish (Türkiye)
            //'        Is 'Bill' the same as 'BILL'? True
            //'        Does 'Bill' start with 'BILL'? False


        }

        public static void PrintValues(string title, IEnumerable myList)
        {
            Console.Write("{0,10}: ", title);
            StringBuilder sb = new StringBuilder();
            foreach (string s in myList)
            {
                sb.AppendFormat("{0}, ", s);
            }
            sb.Remove(sb.Length - 2, 2);
            Console.WriteLine(sb);
        }

        public void ArrayListString()
        {

            ArrayList myAL = new ArrayList();
            myAL.Add("Eric");
            myAL.Add("Mark");
            myAL.Add("Lance");
            myAL.Add("Rob");
            myAL.Add("Kris");
            myAL.Add("Brad");
            myAL.Add("Kit");
            myAL.Add("Bradley");
            myAL.Add("Keith");
            myAL.Add("Susan");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("Count: {0}", myAL.Count);
            PrintValues("Unsorted", myAL);
            myAL.Sort();
            PrintValues("Sorted", myAL);
            myAL.Sort(new ReverseStringComparer());
            PrintValues("Reverse", myAL);

            string[] names = (string[])myAL.ToArray(typeof(string));

        }
    }
}
