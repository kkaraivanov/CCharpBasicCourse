using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            double oddMin = 1000000000;
            double oddMax = -1000000000;
            double oddSum = 0.0;
            double evenMin = 1000000000;
            double evenMax = -1000000000;
            double eveSum = 0.0;

            for (int i = 1; i <= num; i++)
            {
                double curentNum = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += curentNum;
                    if (curentNum < oddMin)
                    {
                        oddMin = curentNum;
                    }
                    if(curentNum > oddMax)
                    {
                        oddMax = curentNum;
                    }
                }
                else
                {
                    eveSum += curentNum;
                    if (curentNum < evenMin)
                    {
                        evenMin = curentNum;
                    }
                    if(curentNum > evenMax)
                    {
                        evenMax = curentNum;
                    }
                }
            }

            if (oddMin == 1000000000 && oddMax == -1000000000)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={eveSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No  ");
            }
            else if(evenMin == 1000000000 && evenMax == -1000000000)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={eveSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={eveSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
