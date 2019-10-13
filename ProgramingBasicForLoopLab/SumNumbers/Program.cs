using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < number; i++)
            {
                result += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
