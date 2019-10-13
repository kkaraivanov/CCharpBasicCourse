using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int numMax = int.MinValue;
            int numMin = int.MaxValue;

            for (int i = 0; i < numbers; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > numMax)
                {
                    numMax = currentNum;
                }
                if (currentNum < numMin)
                {
                    numMin = currentNum;
                }
            }
            Console.WriteLine($"Max number: {numMax}");
            Console.WriteLine($"Min number: {numMin}");
        }
    }
}
