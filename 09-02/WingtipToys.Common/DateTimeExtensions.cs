using System;
using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static class DateTimeExtensions
    {
        public static string ToFriendlyDate(this DateTime dateTime)
        {
            var now = DateTime.Now;
            var span = now - dateTime;

            if (span.TotalSeconds < 60)
                return "Just Now";
            if (span.TotalMinutes < 60)
                return $"{(int)span.TotalMinutes} Minute{(span.TotalMinutes >= 2 ? "s" : "")} Ago";
            if (span.TotalHours < 24)
                return $"{(int)span.TotalHours} Hour{(span.TotalHours >= 2 ? "s" : "")} Ago";
            if (span.TotalDays < 2)
                return "Yesterday";
            if (span.TotalDays < 7)
                return $"{(int)span.TotalDays} Day{(span.TotalDays >= 2 ? "s" : "")} Ago";

            return dateTime.ToString("MMMM dd, yyyy");
        }
    }
}