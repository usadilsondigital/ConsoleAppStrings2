using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Represents a time of day, as would be read from a clock, within the range 00:00:00 to 23:59:59.9999999.
    public class StructTimeOnly
    {
        //properties
        /*  Hour
          Gets the hour component of the time represented by this instance.

          MaxValue
          Gets the largest possible value of TimeOnly.

          Microsecond
          Gets the microsecond component of the time represented by this instance.
                  Millisecond
          Gets the millisecond component of the time represented by this instance.
                  Minute
          Gets the minute component of the time represented by this instance.

          MinValue
          Gets the smallest possible value of TimeOnly.

          Nanosecond
          Gets the nanosecond component of the time represented by this instance.
                  Second
          Gets the seconds component of the time represented by this instance.

          Ticks
          Gets the number of ticks that represent the time of this instance.
                */

        //Methods
        public TimeOnly Add(TimeSpan value, out int wrappedDays);

        public TimeOnly AddHours(double value, out int wrappedDays);

        public TimeOnly AddMinutes(double value);

        public int CompareTo(object? value);

        public void Deconstruct(out int hour, out int minute, out int second, out int millisecond, out int microsecond);

        public bool Equals(TimeOnly value);


        public static TimeOnly FromDateTime(DateTime dateTime);

        public static TimeOnly FromTimeSpan(TimeSpan timeSpan);

        public override int GetHashCode();

        
        public bool IsBetween(TimeOnly start, TimeOnly end);

        public static TimeOnly Parse(string s);

        public static TimeOnly ParseExact(string s, string[] formats, IFormatProvider? provider, System.Globalization.DateTimeStyles style = System.Globalization.DateTimeStyles.None);

        public string ToLongTimeString();

        public string ToShortTimeString();

        public string ToString(string? format, IFormatProvider? provider);

        public TimeSpan ToTimeSpan();

        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format = default, IFormatProvider? provider = default);



    }
}
