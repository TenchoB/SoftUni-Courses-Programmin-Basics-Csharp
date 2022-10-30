using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {

            int numofpenpacks = int.Parse(Console.ReadLine());
            int numofmarkerpacks = int.Parse(Console.ReadLine());
            int litersboarddetergent = int.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine());
            double penpack = 5.80;
            double markerpack = 7.2;
            double detergent = 1.2;
            
            double pricepenpacks = (numofpenpacks * penpack);
            double pricemarkerpacks = (numofmarkerpacks * markerpack);
            double priceliterboarddetregent = (litersboarddetergent * detergent);
            double priceforallmaterials = (pricepenpacks + pricemarkerpacks + priceliterboarddetregent);

            double pricewithdiscount = priceforallmaterials - (priceforallmaterials * (discount / 100));


            Console.WriteLine(pricewithdiscount);
        }
    }
}
