using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDeposit = int.Parse(Console.ReadLine());
            double deposit = 0.0;
            int counter = 0;
            double acountBalance = 0.0;

            while (counter < numberOfDeposit)
            {
                deposit = double.Parse(Console.ReadLine());
                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                acountBalance += deposit;
                Console.WriteLine($"Increase: {deposit:f2}");
                counter++;
            }
            Console.WriteLine($"Total: {acountBalance:f2}");
        }
    }
}
