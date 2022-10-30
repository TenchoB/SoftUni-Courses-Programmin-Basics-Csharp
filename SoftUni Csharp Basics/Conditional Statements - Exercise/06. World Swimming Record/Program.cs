using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeterInSeconds = double.Parse(Console.ReadLine());
            double timeForDistance = distanceInMeters * timePerMeterInSeconds;
            double timesDelayed = Math.Floor(distanceInMeters / 15);
            double delayTime = timesDelayed * 12.5;
            double totalTime = timeForDistance + delayTime;
            bool recordIsBeaten = totalTime < recordInSeconds;
            if (recordIsBeaten)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double insufficientSeconds = totalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {insufficientSeconds:f2} seconds slower.");
            }
        }
    }
}
