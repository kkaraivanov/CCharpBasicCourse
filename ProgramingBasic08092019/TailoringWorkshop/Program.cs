using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double outArea = 0.30;
            const double usdCource = 1.85;

            int tableCount = int.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double clothPrice = 7;
            double kareClothPrice = 9;

            double totalArea = tableCount * (lenghtTable + 2 * outArea) * (height + 2 * outArea);
            double totalKare = tableCount * (lenghtTable / 2) * (lenghtTable / 2);

            double totalPriceUsd = (totalArea * clothPrice) + (totalKare * kareClothPrice);
            double totalPriceBgn = totalPriceUsd * usdCource;

            Console.WriteLine($"{totalPriceUsd:F2} USD");
            Console.WriteLine($"{totalPriceBgn:F2} BGN");
        }
    }
}
