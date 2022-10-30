using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {

            int pagenums = int.Parse(Console.ReadLine());
            int numpagesforhour = int.Parse(Console.ReadLine());
            int daysneededforreadabook = int.Parse(Console.ReadLine());
            int totaltimeforreadthebook = pagenums / numpagesforhour;
            int readinghoursperday = totaltimeforreadthebook / daysneededforreadabook;
            Console.WriteLine(readinghoursperday);
        }
    }
}
