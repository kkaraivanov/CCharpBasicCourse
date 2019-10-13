using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double percent = 0.0;
            double p1 = 0.0, p2 = 0.0, p3 = 0.0;

            for (int i = 1; i <= numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            percent = (p1 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
            percent = (p2 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
            percent = (p3 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
