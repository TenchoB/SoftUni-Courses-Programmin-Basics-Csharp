using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTimeInSeconds = firstTime + secondTime + thirdTime;
            int timeInMinutes = totalTimeInSeconds / 60;
            int remainingSeconds = totalTimeInSeconds % 60;
            Console.WriteLine($"{timeInMinutes}:{remainingSeconds:d2}");
        }
    }
}
