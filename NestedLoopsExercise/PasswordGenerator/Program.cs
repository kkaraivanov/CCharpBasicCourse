using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());


            for (int ferstSymbol = 1; ferstSymbol <= n; ferstSymbol++)
            {
                for (int secondSymbol = 1; secondSymbol <= n; secondSymbol++)
                {
                    for (char threeSymbol = 'a'; threeSymbol < ('a' + l); threeSymbol++)
                    {
                        for (char forteSymbol = 'a'; forteSymbol < ('a' + l); forteSymbol++)
                        {
                            for (int fiveSymbol = 1; fiveSymbol <= n; fiveSymbol++)
                            {
                                if (fiveSymbol > ferstSymbol && fiveSymbol > secondSymbol)
                                {
                                    Console.Write($"{ferstSymbol}{secondSymbol}" +
                                                  $"{threeSymbol}{forteSymbol}{fiveSymbol} ");
                                }
                                
                            }
                        }
                    }
                }
            }
        }
    }
}
