using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a string array that contains the substrings in this instance
    //that are delimited by elements of a specified string or Unicode character array.
    public class StringSplit
    {
        public void TestCase() {
            string s = "You win some. You lose some.";

            string[] subs = s.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
            // This example produces the following output:
            //
            // Substring: You
            // Substring: win
            // Substring: some.
            // Substring: You
            // Substring: lose
            // Substring: some.

        }

        public void TestCase2()
        {

            string s = "You win some. You lose some.";

            string[] subs = s.Split(' ', '.');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
            // This example produces the following output:
            //
            // Substring: You
            // Substring: win
            // Substring: some
            // Substring:
            // Substring: You
            // Substring: lose
            // Substring: some
            // Substring:
        }

        public void TestCase3()
        {
            string s = "You win some. You lose some.";
            char[] separators = new char[] { ' ', '.' };

            string[] subs = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
            // This example produces the following output:
            //
            // Substring: You
            // Substring: win
            // Substring: some
            // Substring: You
            // Substring: lose
            // Substring: some
        }

        public void TestCase4()
        {
            string s = "Today\tI'm going to school";
            string[] subs = s.Split(' ', '\t');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
            // This example produces the following output:
            //
            // Substring: Today
            // Substring: I'm
            // Substring: going
            // Substring: to
            // Substring: school

        }


        public void TestCase5()
        {
            string value = "This is a short string.";
            char delimiter = 's';
            string[] substrings = value.Split(delimiter);
            foreach (var substring in substrings)
                Console.WriteLine(substring);

            // The example displays the following output:
            //     Thi
            //      i
            //      a
            //     hort
            //     tring.
        }

        public void TestCase6()
        {
            string name = "Alex Johnson III";

            string[] subs = name.Split(null, 2);

            string firstName = subs[0];
            string lastName;
            if (subs.Length > 1)
            {
                lastName = subs[1];
            }

            // firstName = "Alex"
            // lastName = "Johnson III"

        }

    }
}
