using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Removes all the leading white-space characters from the current string.
    public class StringTrimStart
    {
        public void TestCase()
        {
            // TrimStart examples
            string lineWithLeadingSpaces = "   Hello World!";
            string lineWithLeadingSymbols = "$$$$Hello World!";
            string lineWithLeadingUnderscores = "_____Hello World!";
            string lineWithLeadingLetters = "xxxxHello World!";
            string lineAfterTrimStart = string.Empty;

            // Make it easy to print out and work with all of the examples
            string[] lines = { lineWithLeadingSpaces, lineWithLeadingSymbols, lineWithLeadingUnderscores, lineWithLeadingLetters };

            foreach (var line in lines)
            {
                Console.WriteLine($"This line has leading characters: {line}");
            }
            // Output:
            // This line has leading characters:    Hello World!
            // This line has leading characters: $$$$Hello World!
            // This line has leading characters: _____Hello World!
            // This line has leading characters: xxxxHello World!



        }

    }
}
