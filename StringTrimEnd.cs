using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Removes all the trailing white-space characters from the current string.
    public class StringTrimEnd
    {
        public void TestCase()
        {
            string sentence = "The dog had a bone, a ball, and other toys.";
            char[] charsToTrim = { ',', '.', ' ' };
            string[] words = sentence.Split();
            foreach (string word in words)
                Console.WriteLine(word.TrimEnd(charsToTrim));

            // The example displays the following output:
            //       The
            //       dog
            //       had
            //       a
            //       bone
            //       a
            //       ball
            //       and
            //       other
            //       toys
        }
    }
}
