using System;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double num = 1;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{num * num}");
                    num *= 2;
                }
            }
        }
    }
}
