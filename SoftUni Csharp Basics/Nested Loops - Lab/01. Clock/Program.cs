using System;
using System.Threading;

namespace _01._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    for (int sec = 0; sec <= 59; sec++)
                    {
                        Console.WriteLine($"{hour:d2}:{min:d2}:{sec:d2}");
                        Thread.Sleep(1000);
                    }
                    
                }
            }
        }
    }
}
