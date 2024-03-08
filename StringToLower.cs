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
        public  void TestCase()
        {

            string[] info = { "Name", "Title", "Age", "Location", "Gender" };

            Console.WriteLine("The initial values in the array are:");
            foreach (string s in info)
                Console.WriteLine(s);

            Console.WriteLine("{0}The lowercase of these values is:", Environment.NewLine);

            foreach (string s in info)
                Console.WriteLine(s.ToLower());

        }
    }
}
