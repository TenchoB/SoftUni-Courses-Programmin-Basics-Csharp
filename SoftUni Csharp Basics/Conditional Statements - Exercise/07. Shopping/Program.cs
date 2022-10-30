using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {


            double availableBudget = double.Parse(Console.ReadLine());
            int gpuNum = int.Parse(Console.ReadLine());
            int cpuNum = int.Parse(Console.ReadLine());
            int ramSlotsNum = int.Parse(Console.ReadLine());


            //            · Видеокарта – 250 лв./ бр.

            //· Процесор – 35 % от цената на закупените видеокарти/ бр.

            //· Рам памет – 10 % от цената на закупените видеокарти/ бр.
            double totalForGPUs = gpuNum * 250;

            double cpuSinglePrice = 0.35 * totalForGPUs;

            double totalforCPUs = cpuNum * cpuSinglePrice;

            double ramSinglePrice = 0.1 * totalForGPUs;

            double totalForRAM = ramSlotsNum * ramSinglePrice;

            double totalForAll = totalForGPUs + totalforCPUs + totalForRAM;
            if(gpuNum > cpuNum)
            {
                double discount = 0.15 * totalForAll;
                totalForAll -= discount;

            }
            if (availableBudget >= totalForAll)
            {
                double moneyRemaining = availableBudget - totalForAll;
                Console.WriteLine($"You have {moneyRemaining:f2} leva left!");
            }
            else
            {
                double insufficient = totalForAll - availableBudget;
                Console.WriteLine($"Not enough money! You need {insufficient:F2} leva more!");
            }
        }
    }
}
