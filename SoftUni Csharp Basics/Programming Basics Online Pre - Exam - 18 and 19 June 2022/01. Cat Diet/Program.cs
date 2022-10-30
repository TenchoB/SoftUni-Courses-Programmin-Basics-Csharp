using System;

namespace _01._Cat_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            //         •	Процент на мазнините - цяло число в интервала[0…100]
            //•	Процент на протеините - цяло число в интервала[0…100]
            //•	Процент на въглехидратите - цяло число в интервала[0…100]
            //•	Общ брой калории - цяло число в интервала[1000…15000]
            //•	Процент на съдържанието на вода - цяло число в интервала[0…100]
            double fat = double.Parse(Console.ReadLine());
            double protein = double.Parse(Console.ReadLine());
            double carbohydrates = double.Parse(Console.ReadLine());
            double totalcalories = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());
            
            double totalgramfat = (totalcalories * (fat / 100)) / 9;
            double totalgramprotein = (totalcalories * (protein / 100)) / 4;
            double totalcarbohydrates = (totalcalories * (carbohydrates / 100) / 4);
            double totalfood = totalgramfat + totalgramprotein + totalcarbohydrates;
            double caloriesfor1gram = totalcalories / totalfood;
            double calories = ((100 - water)/100) * caloriesfor1gram;
            Console.WriteLine($"{calories:f4}");
        }
    }
}
