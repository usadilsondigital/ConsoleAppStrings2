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
                
            }
        }

    }
}
