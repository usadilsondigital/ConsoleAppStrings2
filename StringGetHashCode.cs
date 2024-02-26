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
    }
}
