using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    public class StringGetEnumerator
    {
        public void EnumerateAndDisplay(String phrase)
        {
            Console.WriteLine("The characters in the string \"{0}\" are:",phrase);
            int CharCount = 0;
            int controlChars = 0;
            int alphanumeric = 0;
            int punctuation = 0;

            foreach (var ch in phrase)
            {
                Console.Write(Char.IsControl(ch) ? $"{ch}" : $"0x{(ushort)ch:X4}");
                if (Char.IsLetterOrDigit(ch))
                    alphanumeric++;
                else if (Char.IsControl(ch))
                    controlChars++;
                else if (Char.IsPunctuation(ch))
                    punctuation++;
                CharCount++;

            }
            Console.WriteLine("\n   Total characters:        {0,3}", CharCount);
            Console.WriteLine("   Alphanumeric characters: {0,3}", alphanumeric);
            Console.WriteLine("   Punctuation characters:  {0,3}", punctuation);
            Console.WriteLine("   Control Characters:      {0,3}\n", controlChars);


        }



    }


}
