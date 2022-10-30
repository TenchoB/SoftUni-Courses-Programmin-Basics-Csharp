using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int cakePieces = width * lenght;
            while (cakePieces > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                cakePieces -= int.Parse(input);

            }
            if (cakePieces > 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
        }
    }
}
