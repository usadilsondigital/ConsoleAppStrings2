using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppStrings2
{
    //Retrieves a substring from this instance.This member is overloaded.For complete information about this member,
    //including syntax, usage, and examples, click a name in the overload list.
    public class StringSubstring
    {
        public void GetSubstring() {
            string[] info = { "Name: Felica Walker", "Title: Mz.","Age: 47", "Location: Paris", "Gender: F"};
            int found = 0;

            Console.WriteLine("The initial values in the array are:");
            foreach (string s in info)
                Console.WriteLine(s);
            Console.WriteLine("\nWe want to retrieve only the key information. That is:");
            foreach (string s in info)
            {
                found = s.IndexOf(": ");
                Console.WriteLine("   {0}", s.Substring(found + 2));
            }

            // The example displays the following output:
            //       The initial values in the array are:
            //       Name: Felica Walker
            //       Title: Mz.
            //       Age: 47
            //       Location: Paris
            //       Gender: F
            //       
            //       We want to retrieve only the key information. That is:
            //          Felica Walker
            //          Mz.
            //          47
            //          Paris
            //          F
        }

        //The following example uses the Substring method to separate key/value pairs
        //that are delimited by an equals (=) character.
        public void SeparateValues() {
            String[] pairs = { "Color1=red", "Color2=green", "Color3=blue","Title=Code Repository" };
            foreach (var pair in pairs)
            {
                int position = pair.IndexOf("=");
                if (position < 0)
                    continue;
                Console.WriteLine("Key: {0}, Value: '{1}'",pair.Substring(0, position),pair.Substring(position + 1));
            }
            // The example displays the following output:
            //     Key: Color1, Value: 'red'
            //     Key: Color2, Value: 'green'
            //     Key: Color3, Value: 'blue'
            //     Key: Title, Value: 'Code Repository'
        }

        //extracts two characters
        public void TestCase() {
            String value = "This is a string.";
            int startIndex = 5;
            int length = 2;
            String substring = value.Substring(startIndex, length);
            Console.WriteLine(substring);
            // The example displays the following output:
            //       is
        }

        public void TestCase2() {
            string myString = "abc";
            bool test1 = myString.Substring(2, 1).Equals("c"); // This is true.
            Console.WriteLine(test1);
            bool test2 = string.IsNullOrEmpty(myString.Substring(3, 0)); // This is true.
            Console.WriteLine(test2);
            try
            {
                string str3 = myString.Substring(3, 1); // This throws ArgumentOutOfRangeException.
                Console.WriteLine(str3);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
