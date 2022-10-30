using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double vacantionPrice = double.Parse(Console.ReadLine());
                int puzzles = int.Parse(Console.ReadLine());
                int dolls = int.Parse(Console.ReadLine());
                int bears = int.Parse(Console.ReadLine());
                int minions = int.Parse(Console.ReadLine());
                int trucks = int.Parse(Console.ReadLine());

                int toys = puzzles + dolls + bears + minions + trucks;

                double totalPrice = (puzzles * 2.6) + (dolls * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);

                double discount = totalPrice * 0.25;

                if (toys >= 50)
                {
                    totalPrice = totalPrice - discount;
                }

                double totalPriceWithRent = totalPrice - (totalPrice * 0.1);

                if (totalPriceWithRent >= vacantionPrice)
                {
                    Console.WriteLine($"Yes! {totalPriceWithRent - vacantionPrice:f2} lv left.");
                }

                else
                {
                    Console.WriteLine($"Not enough money! {vacantionPrice - totalPriceWithRent:f2} lv needed.");
                }

            }
        }
    }
}


