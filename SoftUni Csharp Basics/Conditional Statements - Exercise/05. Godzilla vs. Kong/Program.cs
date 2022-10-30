using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceclothesstatist = double.Parse(Console.ReadLine());
            double moviedecor = budget * 0.1;
            double sumforclothes = statists * priceclothesstatist;
            double totalpriceformovie = moviedecor + sumforclothes;
            double discount = sumforclothes * 0.1;

            if (statists > 150)
            {
                totalpriceformovie = moviedecor + (sumforclothes - discount);
            }
            if (totalpriceformovie > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {totalpriceformovie - budget:f2} leva more.");
            }
            else if (totalpriceformovie <= budget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalpriceformovie:f2} leva left.");
            }
            

            
        }
    }
}
