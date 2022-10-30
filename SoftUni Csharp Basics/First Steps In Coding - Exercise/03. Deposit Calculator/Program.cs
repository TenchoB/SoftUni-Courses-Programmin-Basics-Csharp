using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int monthsperiod = int.Parse(Console.ReadLine());
            double annualinterestrate = double.Parse(Console.ReadLine());

            double dividend = deposit * (annualinterestrate / 100);
            double monthdivident = dividend / 12;
            double totalamount = deposit + (monthsperiod * monthdivident);



            Console.WriteLine(totalamount);
        }
    }
}
