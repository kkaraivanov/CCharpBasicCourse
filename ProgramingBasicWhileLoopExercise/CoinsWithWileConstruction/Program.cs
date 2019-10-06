using System;

namespace CoinsWithWileConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());

            change = change * 100;
            int coins = 0;

            while (change > 0)
            {
                if (change >= 200) // 2лв. връща 1 монета
                {
                    change -= 200;
                    coins++;
                }
                else if(change >= 100) // 1лв. връща 1 монета
                {
                    change -= 100;
                    coins++;
                }
                else if(change >= 50) // 50ст. връща 1 монета
                {
                    change -= 50;
                    coins++;
                }
                else if(change >= 20) // 20ст. връща 1 монета
                {
                    change -= 20;
                    coins++;
                }
                else if(change >= 10) // 10ст. връща 1 монета
                {
                    change -= 10;
                    coins++;
                }
                else if(change >= 5) // 5ст. връща 1 монета
                {
                    change -= 5;
                    coins++;
                }
                else if(change >= 2) // 2ст. връща 1 монета
                {
                    change -= 2;
                    coins++;
                }
                else // 1ст. връща 1 монета
                {
                    change -= 1;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
