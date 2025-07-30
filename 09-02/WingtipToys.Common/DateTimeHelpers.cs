using System;
using System.Collections.Generic;
using System.Linq;

namespace WingtipToys.Common
{
    public static class DateTimeHelpers
    {

        public static DateTime GetLatestDate<T>(IList<T> source, Func<T, DateTime> dateSelector)
        {
            if (source == null || !source.Any())
                return DateTime.MinValue;

            return source.Max(dateSelector);
        }

        public static DateTime GeOldestDate<T>(IList<T> source, Func<T, DateTime> dateSelector)
        {
            if (source == null || !source.Any())
                return DateTime.MinValue;

            return source.Min(dateSelector);
        }
    }
}