using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int fifteenMinutes = 15;
            minutes += fifteenMinutes;
            if (minutes > 59)
            {
                hour = hour + 1;
                if (hour > 23)
                {
                    hour = 0;
                }
                minutes = minutes - 60;

            }
            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
