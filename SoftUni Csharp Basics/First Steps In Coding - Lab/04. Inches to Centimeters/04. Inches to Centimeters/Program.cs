using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double inch = 2.54;
            double result = num * inch;
            Console.WriteLine(result);
        }
    }
}
