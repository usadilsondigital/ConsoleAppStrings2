using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{

    //Concatenates one or more instances of String, or the String representations of the values of one or more instances of Object
    internal class StringConcat
    {
        const int WORD_SIZE = 4;

        public void ScrambleGame() {
            // Define some 4-letter words to be scrambled.
            string[] words = { "home", "food", "game", "rest" };
            // Define two arrays equal to the number of letters in each word.
            double[] keys = new double[WORD_SIZE];
            string[] letters = new string[WORD_SIZE];
            // Initialize the random number generator.
            Random rnd = new Random();

            // Scramble each word.
            foreach (string word in words)
            {
                for (int ctr = 0; ctr < word.Length; ctr++)
                {
                    // Populate the array of keys with random numbers.
                    keys[ctr] = rnd.NextDouble();
                    // Assign a letter to the array of letters.
                    letters[ctr] = word[ctr].ToString();
                }
                // Sort the array. 
                Array.Sort(keys, letters, 0, WORD_SIZE, Comparer.Default);
                // Display the scrambled word.
                string scrambledWord = String.Concat(letters[0], letters[1], letters[2], letters[3]);

            }
            // The example displays output like the following:
            //       home --> mheo
            //       food --> oodf
            //       game --> aemg
            //       rest --> trse
        }

        public void StringConcat5() {
            int i = -123;
            Object o = i;
            Object[] objs = new Object[] { -123, -456, -789 };

            Console.WriteLine("Concatenate 1, 2, and 3 objects:");
            Console.WriteLine("1) {0}", String.Concat(o));
            Console.WriteLine("2) {0}", String.Concat(o, o));
            Console.WriteLine("3) {0}", String.Concat(o, o, o));
            Console.WriteLine("\nConcatenate 4 objects and a variable length parameter list:");
            Console.WriteLine("4) {0}", String.Concat(o, o, o, o));
            Console.WriteLine("5) {0}", String.Concat(o, o, o, o, o));
            Console.WriteLine("\nConcatenate a 3-element object array:");
            Console.WriteLine("6) {0}", String.Concat(objs));
            // The example displays the following output:
            //    Concatenate 1, 2, and 3 objects:
            //    1) -123
            //    2) -123-123
            //    3) -123-123-123
            //
            //    Concatenate 4 objects and a variable length parameter list:
            //    4) -123-123-123-123
            //    5) -123-123-123-123-123
            //
            //    Concatenate a 3-element object array:
            //    6) -123-456-789
        }


        public void ConcatTest() {
            // we want to simply quickly add this person's name together
            string fName = "Simon";
            string mName = "Jake";
            string lName = "Harrows";
            // because we want a name to appear with a space in between each name,
            // put a space on the front of the middle, and last name, allowing for
            // the fact that a space may already be there
            mName = " " + mName.Trim();
            lName = " " + lName.Trim();

            // this line simply concatenates the two strings
            Console.WriteLine("Welcome to this page, '{0}'!", string.Concat(string.Concat(fName, mName), lName));

        }


    }
    }
