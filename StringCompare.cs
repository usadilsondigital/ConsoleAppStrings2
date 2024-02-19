using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    internal class StringCompare
    {
        public string name1 { get; set; }
        public string name2 { get; set; }

        public StringCompare()
        {
            name1 = string.Empty;
            name2 = string.Empty;
        }

        public StringCompare(string name1,string name2)
        {
            this.name1 = name1 ?? string.Empty;
            this.name2 = name2 ?? string.Empty;
        }

        public void UsingCompare() {
             name1 = "Jack Smith";
             name2 = "John Doe";

            // Get position of character after the space character.
            int index1 = name1.IndexOf(" ");
            index1 = index1 < 0 ? 0 : ++index1;
            int index2 = name2.IndexOf(" ");
            index2 = index2 < 0 ? 0 : ++index2;

            int max_length = Math.Max(name1.Length, name2.Length);




        }
    }
}
