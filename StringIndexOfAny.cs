using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Reports the index of the first occurrence in this instance of any character in a specified array of Unicode characters.
    //The method returns -1 if the characters in the array are not found in this instance.
    public class StringIndexOfAny
    {
        public  void TestCase()
        {
            char[] chars = { 'a', 'e', 'i', 'o', 'u', 'y','A', 'E', 'I', 'O', 'U', 'Y' };
            String s = "The long and winding road...";
            Console.WriteLine("The first vowel in \n   {0}\nis found at position {1}",
                              s, s.IndexOfAny(chars) + 1);
        }
    }
}
