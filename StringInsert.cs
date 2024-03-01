using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a new string in which a specified string is inserted at a specified index position in this instance.
    public class StringInsert
    {
        public  void TestCase()
        {
            String original = "aaabbb";
            Console.WriteLine("The original string: '{0}'", original);
            String modified = original.Insert(3, " ");
            Console.WriteLine("The modified string: '{0}'", modified);
            // The example displays the following output:
            //     The original string: 'aaabbb'
            //     The modified string: 'aaa bbb'
        }
        public void InsertAdjective()
        {
            string animal1 = "fox";
            string animal2 = "dog";

            string strTarget = String.Format("The {0} jumps over the {1}.",animal1, animal2);
            Console.WriteLine("The original string is:{0}{1}{0}",Environment.NewLine, strTarget);
            Console.Write("Enter an adjective (or group of adjectives) " +
                          "to describe the {0}: ==> ", animal1);
            string adj1 = Console.ReadLine();
            Console.Write("Enter an adjective (or group of adjectives) " +
                      "to describe the {0}: ==> ", animal2);
            string adj2 = Console.ReadLine();

            adj1 = adj1.Trim() + " ";
            adj2 = adj2.Trim() + " ";

            strTarget = strTarget.Insert(strTarget.IndexOf(animal1), adj1);
            strTarget = strTarget.Insert(strTarget.IndexOf(animal2), adj2);
            Console.WriteLine("{0}The final string is:{0}{1}",Environment.NewLine, strTarget);'
               
        }


        }
}
