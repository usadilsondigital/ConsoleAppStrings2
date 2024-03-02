using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Concatenates the elements of a specified
    //array or the members of a collection, using the specified separator between each element or member.
    public class StringJoin
    {
        public  void TestCase()
        {
            int maxPrime = 100;
            List<int> primes = GetPrimes(maxPrime);
            Console.WriteLine("Primes less than {0}:", maxPrime);
            Console.WriteLine("   {0}", String.Join(" ", primes));
        }

        private static List<int> GetPrimes(int maxPrime)
        {
            Array values = Array.CreateInstance(typeof(int),
                                    new int[] { maxPrime - 1 }, new int[] { 2 });
            // Use Sieve of Eratosthenes to determine prime numbers.
            for (int ctr = values.GetLowerBound(0); ctr <= (int)Math.Ceiling(Math.Sqrt(values.GetUpperBound(0))); ctr++)
            {

                if ((int)values.GetValue(ctr) == 1) continue;

                for (int multiplier = ctr; multiplier <= maxPrime / 2; multiplier++)
                    if (ctr * multiplier <= maxPrime)
                        values.SetValue(1, ctr * multiplier);

            }
            List<int> primes = new List<int>();
            for (int ctr = values.GetLowerBound(0); ctr <= values.GetUpperBound(0); ctr++)
                if ((int)values.GetValue(ctr) == 0)
                    primes.Add(ctr);
            return primes;
        }
        // The example displays the following output:
        //    Primes less than 100:
        //       2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97



        public  void JoinAlphabet()
        {
            string output = String.Join(" ", GetAlphabet(true).Where(letter => letter.CompareTo("M") >= 0));
            Console.WriteLine(output);
        }
        
          private List<string> GetAlphabet(bool upper)
        {
            List<string> alphabet = new List<string>();
            int charValue = upper ? 65 : 97;
            for (int ctr = 0; ctr <= 25; ctr++)
                alphabet.Add(((char)(charValue + ctr)).ToString());
            return alphabet;
            // The example displays the following output:
            //      M N O P Q R S T U V W X Y Z
        }


        public  void MakeLineTestCase()
        {
            Console.WriteLine(MakeLine(0, 5, ", "));
            Console.WriteLine(MakeLine(1, 6, "  "));
            Console.WriteLine(MakeLine(9, 9, ": "));
            Console.WriteLine(MakeLine(4, 7, "< "));
        }
        private string MakeLine(int initVal, int multVal, string sep)
        {
            string[] sArr = new string[10];
            for (int i = initVal; i < initVal + 10; i++)
                sArr[i - initVal] = String.Format("{0,-3}", i * multVal);

            return String.Join(sep, sArr);

        }
        // The example displays the following output:
        //       0  , 5  , 10 , 15 , 20 , 25 , 30 , 35 , 40 , 45
        //       6    12   18   24   30   36   42   48   54   60
        //       81 : 90 : 99 : 108: 117: 126: 135: 144: 153: 162
        //       28 < 35 < 42 < 49 < 56 < 63 < 70 < 77 < 84 < 91



        //The following example concatenates two elements from an array of names of fruit.
        public void ConcatenateFruit() {
            String[] val = { "apple", "orange", "grape", "pear" };
            String sep = ", ";
            String result;

            Console.WriteLine("sep = '{0}'", sep);
            Console.WriteLine("val[] = {{'{0}' '{1}' '{2}' '{3}'}}", val[0], val[1], val[2], val[3]);
            result = String.Join(sep, val, 1, 2);
            Console.WriteLine("String.Join(sep, val, 1, 2) = '{0}'", result);
            // This example produces the following results:
            // sep = ', '
            // val[] = {'apple' 'orange' 'grape' 'pear'}
            // String.Join(sep, val, 1, 2) = 'orange, grape'
        }


        public void JoinAnimalExample() {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Animal("Squirrel", "Rodent"));
            animals.Add(new Animal("Gray Wolf", "Carnivora"));
            animals.Add(new Animal("Capybara", "Rodent"));  
        }


    }
}
