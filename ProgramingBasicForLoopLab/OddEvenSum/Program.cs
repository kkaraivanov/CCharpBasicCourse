using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int even = 0;
            int odd = 0;

            for (int i = 0; i < numbers; i++)
            {
                int curent = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += curent;
                }
                else
                {
                    odd += curent;
                }
            }

            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(even - odd)}");
            }
        }
    }
}
