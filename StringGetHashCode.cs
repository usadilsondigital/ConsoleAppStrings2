using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    public class StringGetHashCode
    {
        public void DisplayHashCode(String Operand)
        {
            int HashCode = Operand.GetHashCode();
            Console.WriteLine("The hash code for \"{0}\" is: 0x{1:X8}, {1}", Operand, HashCode);
        }

        public  void TestCase()
        {
            DisplayHashCode("");
            DisplayHashCode("a");
            DisplayHashCode("ab");
            DisplayHashCode("abc");
            DisplayHashCode("abd");
            DisplayHashCode("abe");
            DisplayHashCode("abcdef");
            DisplayHashCode("abcdeg");
            DisplayHashCode("abcdeh");
            DisplayHashCode("abcdei");
            DisplayHashCode("Abcdeg");
            DisplayHashCode("Abcdeh");
            DisplayHashCode("Abcdei");
        }

    }
}
