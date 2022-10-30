using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesTitle = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());
            double timeForLunch = breakDuration / 8.0;
            double doNothingTime = breakDuration / 4.0;
            double timeForEpisode = breakDuration - timeForLunch - doNothingTime;
            if (timeForEpisode >= episodeDuration)
            {
                double timeLeft = Math.Ceiling(timeForEpisode - episodeDuration);
                Console.WriteLine($"You have enough time to watch {seriesTitle} " + $"and left with {timeLeft} minutes free time.");
            }
            else
            {
                double timeNeeded = Math.Ceiling(episodeDuration - timeForEpisode);
                Console.WriteLine($"You don't have enough time to watch {seriesTitle}, " + $"you need {timeNeeded} more minutes.");
            }
        }
    }
}
