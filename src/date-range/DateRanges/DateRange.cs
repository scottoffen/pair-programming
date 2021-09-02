using System;

namespace DateRanges
{
    public class DateRange : IEquatable<DateRange>
    {
        public DateTime Begin { get; }
        public DateTime End { get; }

        public DateRange(DateTime begin, DateTime end)
        {
            Begin = begin;
            End = end;
        }

        public bool Equals(DateRange other)
        {
            if (other == null) throw new ArgumentNullException(nameof(other));
            return Begin == other.Begin && End == other.End;
        }
    }
}
