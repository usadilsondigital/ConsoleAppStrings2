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

            // A basic demonstration of TrimStart in action
            lineAfterTrimStart = lineWithLeadingSpaces.TrimStart(' ');
            Console.WriteLine($"This is the result after calling TrimStart: {lineAfterTrimStart}");
            // This is the result after calling TrimStart: Hello World!   

            // Since TrimStart accepts a character array of leading items to be removed as an argument,
            // it's possible to do things like trim multiple pieces of data that each have different 
            // leading characters,
            foreach (var lineToEdit in lines)
            {
                Console.WriteLine(lineToEdit.TrimStart(' ', '$', '_', 'x'));
            }
            // Result for each: Hello World!

            // or handle pieces of data that have multiple kinds of leading characters 
            var lineToBeTrimmed = "__###__ John Smith";
            lineAfterTrimStart = lineToBeTrimmed.TrimStart('_', '#', ' ');
            Console.WriteLine(lineAfterTrimStart);
            // Result: John Smith

        }

    }
}
