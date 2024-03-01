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

        }




        }
}
