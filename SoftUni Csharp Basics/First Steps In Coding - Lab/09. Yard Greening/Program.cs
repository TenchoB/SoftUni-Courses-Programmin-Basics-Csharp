using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squaremetersforlandscaping = double.Parse(Console.ReadLine());
            double priceforonesquaremeter = 7.61;
            double discount = 0.18;
            double priceforallyard = squaremetersforlandscaping * priceforonesquaremeter;
            double finaldiscount = priceforallyard * discount;
            double finalprice = priceforallyard - finaldiscount;
            Console.WriteLine($"The final price is: {finalprice} lv.");
            Console.WriteLine($"The discount is: {finaldiscount} lv.");

        }
    }
}
