using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Specifies the culture, case, and sort rules to be used by certain
    //overloads of the Compare(String, String) and Equals(Object) methods
    public class StringComparison
    {
            public  void TestCase()
            {
                String[] cultureNames = { "en-US", "th-TH", "tr-TR" };
                String[] strings1 = { "a", "i", "case", };
                String[] strings2 = { "a-", "\u0130", "Case" };
                StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);

            }

        }
        }
    }
