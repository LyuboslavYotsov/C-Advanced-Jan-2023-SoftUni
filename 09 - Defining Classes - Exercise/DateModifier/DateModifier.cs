

using System;

namespace DateModifier
{
    public class DateModifier
    {

        public int CalculateDaysDifference(string date1, string date2)
        {
            int days = 0;
            DateTime firstDate = DateTime.Parse(date1);
            DateTime secondDate = DateTime.Parse(date2);

            days = secondDate.Subtract(firstDate).Days;

            return Math.Abs(days);
        }
    }
}
