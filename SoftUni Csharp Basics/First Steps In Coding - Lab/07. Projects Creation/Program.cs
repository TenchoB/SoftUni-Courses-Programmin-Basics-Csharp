using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectnum = int.Parse(Console.ReadLine());
            int projecthours = projectnum * 3;
            
            Console.WriteLine($"The architect {name} will need {projecthours} hours to complete {projectnum} project/s.");
        }
    }
}
