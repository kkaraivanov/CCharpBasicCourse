using System;

namespace GodzillaKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double buged = double.Parse(Console.ReadLine());
            int artistCount = int.Parse(Console.ReadLine());
            double clothPrice = double.Parse(Console.ReadLine());

            double decorMovie = buged * 0.10;
            double pricePerArtistCloth = artistCount * clothPrice;

            if (artistCount > 150)
            {
                pricePerArtistCloth = pricePerArtistCloth * 0.90;
            }
            double neededMoney = pricePerArtistCloth + decorMovie;

            if (neededMoney > buged)
            {
                double result = neededMoney - buged;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {result:f2} leva more.");
            }
            else
            {
                double result = buged - neededMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {result:f2} leva left.");
            }
        }
    }
}
