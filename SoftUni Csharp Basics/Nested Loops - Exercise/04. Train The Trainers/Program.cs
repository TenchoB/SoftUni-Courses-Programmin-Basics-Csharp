using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            //average score from every task
            // total average score
            int jurry = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            int countGrades = 0;
            double allgrades = 0;
            while (presentation != "Finish")
            {
                double totalGrades = 0;

                for (int i = 1; i <= jurry; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    totalGrades += grades;
                    allgrades += grades;
                    countGrades++;
                }

                Console.WriteLine($"{presentation} - {totalGrades / jurry:f2}.");
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {allgrades / countGrades:f2}.");
        }
    }
}
