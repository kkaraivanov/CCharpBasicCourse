using System;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int n = 1;
            while (n <= number)
            {
                Console.WriteLine(n);
                n = n * 2 + 1;
            }
        }
    }
}
