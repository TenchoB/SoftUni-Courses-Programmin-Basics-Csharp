using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numchickenmenu = int.Parse(Console.ReadLine());
            int numfishmenu = int.Parse(Console.ReadLine());
            int numvegetarianmenu = int.Parse(Console.ReadLine());
            double chikenmenu = 10.35;
            double fishmenu = 12.40;
            double vegetarianmenu = 8.15;
            double priceforchickenmenu = numchickenmenu * chikenmenu;
            double priceforfishmenu = numfishmenu * fishmenu;
            double priceforvagetaianmenu = numvegetarianmenu * vegetarianmenu;
            double totalpriceforallmenu = priceforchickenmenu + priceforfishmenu + priceforvagetaianmenu;
            double deserts = totalpriceforallmenu * 0.2;
            double delivery = 2.50;
            double totalprice = totalpriceforallmenu + deserts + delivery;


            Console.WriteLine(totalprice);
        }
    }
}
