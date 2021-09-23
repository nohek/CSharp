using System;
using System.Globalization;

namespace Methods
{
    class BirthDayCalculator
    {
        static void Main(string[] args)
        {

            DateOfBirth();
            var usersDateOfBirth = AskForDateOfBirth();
            var dayOfWeek = usersDateOfBirth.DayOfWeek;
            Console.WriteLine(dayOfWeek);

        }

        public static void DateOfBirth()
        {
            Console.WriteLine("i will guess the day of the week you were born on");
        }
        public static DateTimeOffset AskForDateOfBirth()
        {
            Console.WriteLine("whats your date of birth? " + CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern);

            var userText = Console.ReadLine();

            return DateTimeOffset.Parse(userText);

        }
    }
}
