using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double fishtankvolume = length * width * high;
            double volumeinliters = fishtankvolume * 0.001;
            double occupiedspace = percent / 100;
            double totallitersofwater = volumeinliters * (1 - occupiedspace);



            Console.WriteLine(totallitersofwater);
        }
    }
}
