using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {

            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int paintthinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double pricenylon = 1.5;
            double pricepaint = 14.50;
            double pricepaintthinner = 5;

            double amountofnylon = (nylon + 2) * pricenylon;
            double amountpaint = (paint + (0.10 * paint)) * pricepaint;
            double amountpainthinner = paintthinner * pricepaintthinner;
            double amountpacks = 0.40;
            double totalpriceformaterials = amountofnylon + amountpaint + amountpainthinner + amountpacks;
            double sumpainters = (totalpriceformaterials * 0.3) * hours;
            double totalprice = totalpriceformaterials + sumpainters;
               
            Console.WriteLine(totalprice);
        }
    }
}
