using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeNumber = 0;
            int noPrimeNumber = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int curentNumber = int.Parse(input);
                bool prime = curentNumber >= 2;
                if (curentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                for (int i = 2; i * i<= curentNumber; i++)
                {
                    if (curentNumber % i == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    primeNumber += curentNumber;
                }
                else
                {
                    noPrimeNumber += curentNumber;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {noPrimeNumber}");
        }
    }
}
