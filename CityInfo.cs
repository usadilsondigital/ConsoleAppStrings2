using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    public class CityInfo
    {
        public CityInfo(String name, int population, Decimal area, int year)
        {
            this.Name = name;
            this.Population = population;
            this.Area = area;
            this.Year = year;
        }

        public readonly String Name;
        public readonly int Population;
        public readonly Decimal Area;
        public readonly int Year;
    }
}
