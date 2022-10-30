using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int roomvolume = width * lenght * height;
            while (roomvolume > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                roomvolume -= int.Parse(input);

            }
            if (roomvolume > 0)
            {
                Console.WriteLine($"{roomvolume} Cubic meters left.");
            }
            else
            {
                int absoluteRoomVolumeValue = Math.Abs(roomvolume);
                Console.WriteLine($"No more free space! You need {absoluteRoomVolumeValue} Cubic meters more.");
            }
        }
    }
}
