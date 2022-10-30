using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numpacksfoodfordogs = int.Parse(Console.ReadLine());
            int numpacksfoodfocats = int.Parse(Console.ReadLine());
            double foodfordog = 2.50;
            double foodforcat = 4;
            double totalprice = (numpacksfoodfordogs * foodfordog) + (numpacksfoodfocats * foodforcat);
            Console.WriteLine($"{totalprice} lv.");
        }
    }
}
