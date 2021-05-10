using System;

namespace DateUtils
{
    public class DateFormatter
    {
        public string Format(DateTime date)
        {
            return date.ToShortDateString();
        }
    }
}
