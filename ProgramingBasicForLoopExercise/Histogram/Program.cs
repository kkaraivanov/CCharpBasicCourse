using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            double percent = 0.0;
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 0; i < numbers; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num < 400)
                {
                    p2++;
                }
                else if (num >= 400 && num < 600)
                {
                    p3++;
                }
                else if (num >= 600 && num < 800)
                {
                    p4++;
                }
                else if (num >= 800)
                {
                    p5++;
                }
            }
            percent = (p1 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
            percent = (p2 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
            percent = (p3 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
            percent = (p4 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
            percent = (p5 / numbers) * 100;
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
