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
        }

    }
}
