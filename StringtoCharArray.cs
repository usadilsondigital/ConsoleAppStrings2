using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Copies the characters in this instance to a Unicode character array.
    public class StringtoCharArray
    {
        public void TestCase()
        {
            string str = "012wxyz789";
            char[] arr;
            arr = str.ToCharArray(3, 4);
            Console.Write("The letters in '{0}' are: '", str);
            Console.Write(arr);
            Console.WriteLine("'");
            Console.WriteLine("Each letter in '{0}' is:", str);
            foreach (char c in arr)
                Console.WriteLine(c);
        }

    
    }
}
