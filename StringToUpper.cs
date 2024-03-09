using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a copy of this string converted to uppercase.
    public class StringToUpper
    {
        public  void ToUpper()
        {
            int n = 0;
            for (int ctr = 0x20; ctr <= 0x017F; ctr++)
            {
                string string1 = ((char)ctr).ToString();
                string upperString = string1.ToUpper();

                if (string1 != upperString)
                {
                    Console.Write(@"{0} (\u+{1}) --> {2} (\u+{3})         ",
                                  string1,
                                  Convert.ToUInt16(string1[0]).ToString("X4"),
                                  upperString,
                                  Convert.ToUInt16(upperString[0]).ToString("X4"));
                    n++;
                    if (n % 2 == 0) Console.WriteLine();
                }

            }
        }

    }
}
