using System;

namespace _04._Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	На първия ред – N – брой дни, в които г-жа Иванова тренира  – цяло число в интервала[1...50]
            //•	На втория ред – M – километрите, които е избягала първия ден – реално число в интервала[1.00…500.00]
            //•	За всеки един ден на отделен ред:
            //	Процентите, с които се увеличава дневната си норма – цяло число в интервала[1…100]
            int n = int.Parse(Console.ReadLine());
            double firstDay = double.Parse(Console.ReadLine());

            double allKm = firstDay;
            for (int i = 0; i < n; i++)
            {
                double nextDay = double.Parse(Console.ReadLine());
                firstDay = firstDay + firstDay * (nextDay / 100D);
                allKm += firstDay;
            }

            if (allKm >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(allKm - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - allKm)} more kilometers");
            }
        }
    }
}
