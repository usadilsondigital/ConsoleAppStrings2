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
            string scrambledWord = String.Concat(letters[0], letters[1],letters[2], letters[3]);


        }
    }
}
