using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startRnge = int.Parse(Console.ReadLine());
            int endRnge = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int ferstNum = 0;
            int secondNum = 0;
            int counter = 0;

            for (int i = startRnge; i <= endRnge; i++)
            {
                for (int j = startRnge; j <= endRnge; j++)
                {
                    ferstNum = i;
                    secondNum = j;
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({ferstNum} + {secondNum} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
