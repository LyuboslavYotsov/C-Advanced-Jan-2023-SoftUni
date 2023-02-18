using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main()
        {
            DateModifier date = new DateModifier();

            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            Console.WriteLine(date.CalculateDaysDifference(date1, date2));
        }
    }
}
