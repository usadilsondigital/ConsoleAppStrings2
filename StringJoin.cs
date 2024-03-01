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

    }
}
