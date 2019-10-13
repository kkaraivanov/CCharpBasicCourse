using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int sumL = 0;
            int sumR = 0;

            for (int i = 0; i < numbers; i++)
            {
                sumL += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers; i++)
            {
                sumR += int.Parse(Console.ReadLine());
            }
            if (sumL == sumR)
            {
                Console.WriteLine($"Yes, sum = {sumL}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumL - sumR)}");
            }
        }
    }
}
