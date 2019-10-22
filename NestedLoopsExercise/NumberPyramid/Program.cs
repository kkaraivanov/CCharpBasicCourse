using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            bool isChek = false;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (counter > n)
                    {
                        isChek = true;
                        break;
                    }
                    Console.Write(counter + " ");
                    counter++;
                }
                if (isChek)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
