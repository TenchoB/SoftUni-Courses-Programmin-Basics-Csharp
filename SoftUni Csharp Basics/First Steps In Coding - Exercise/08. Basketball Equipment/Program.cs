using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxyearbasketball = int.Parse(Console.ReadLine());
            double basketballshoes = taxyearbasketball - (taxyearbasketball * 0.4);
            double basketballclothes = basketballshoes - (basketballshoes * 0.2);
            double basketball = 0.25 * basketballclothes;
            double basketballaccecories = 0.2 * basketball;
            double totalpriceforallclothes = taxyearbasketball + basketballshoes + basketballclothes + basketball + basketballaccecories;


            Console.WriteLine(totalpriceforallclothes);
        }
    }
}
