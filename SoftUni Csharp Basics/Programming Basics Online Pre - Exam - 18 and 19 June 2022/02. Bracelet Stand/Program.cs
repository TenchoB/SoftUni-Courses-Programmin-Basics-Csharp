using System;

namespace _02._Bracelet_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            //•Първи ред – джобните на Тереза на ден – реално число в интервала[1.00...100.00]
            //•	Втори ред – парите, които тя печели на ден от продажби – реално число в интервала[1.00...1000.00]
            //•	Трети ред – разходите на Тереза за целия период – реално число в интервала[1.00...1000.00]
            //•	Четвърти ред – цената на подаръка – реално число в интервала[1.00...10000.00]
            double pocketMoney = double.Parse(Console.ReadLine());
            double profitperDay = double.Parse(Console.ReadLine());
            double costsforAllPeriod = double.Parse(Console.ReadLine());
            double pricePresent = double.Parse(Console.ReadLine());
            double totalpocketMoney = 5 * pocketMoney;
            double pricefromSales = 5 * profitperDay;
            double totalMoney = totalpocketMoney + pricefromSales;
            double totalmoneywithoutcosts = totalMoney - costsforAllPeriod;
            if (totalmoneywithoutcosts > pricePresent)
            {
                Console.WriteLine($"Profit: {totalmoneywithoutcosts:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {(pricePresent - totalmoneywithoutcosts):f2} BGN.");
            }

        }
    }
}
