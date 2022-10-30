using System;

namespace _03._Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Брой танцьори – цяло число в интервала[1 … 10]
            //2.Брой точки – реално число в интервала[1.00 … 10000.00]
            //3.Сезон –  текст със следните възможности -"summer" или "winter"
            //4.Място – текст със следните възможности -"Bulgaria" или "Abroad"
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double reward = 0;
            double charity = 0;
            double totalsum = 0;
            double moneyperdancer = 0;
            if (place == "Bulgaria")
            {
                reward = points * dancers;
                if (season == "summer")
                {
                    reward = reward - (0.05 * reward);
                }
                else if (season == "winter")
                {
                    reward = reward - (0.08 * reward);
                }
            }
            else if (place == "Abroad")
            {
                reward = (dancers * points) + (0.5 * (dancers * points));
                if (season == "summer")
                {
                    reward = reward - (0.10 * reward);
                }
                else if (season == "winter")
                {
                    reward = reward - (0.15 * reward);
                }
            }
            charity = 0.75 * reward;
            totalsum = reward - charity;
            moneyperdancer = totalsum / dancers;
            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - { moneyperdancer:f2}");

        }
    }
}
