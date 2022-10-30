using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int firstnum = 1; firstnum <= 10; firstnum++)
            {
                
                for (int secondnum = 1; secondnum <= 10; secondnum++)
                {
                    int result = firstnum * secondnum;
                    Console.WriteLine($"{ firstnum} * { secondnum} = {result}");
                }
            }
        }
    }
}
