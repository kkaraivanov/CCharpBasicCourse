using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double wiskiPrice = double.Parse(Console.ReadLine());
            double beerCount = double.Parse(Console.ReadLine());
            double vineCount = double.Parse(Console.ReadLine());
            double rakiaCount = double.Parse(Console.ReadLine());
            double wiskiCount = double.Parse(Console.ReadLine());

            double rakiaPrice = wiskiPrice / 2;
            double beerPrice = rakiaPrice - (rakiaPrice * 0.80);
            double vinePrice = rakiaPrice - (rakiaPrice * 0.40);

            double totalPrice = (rakiaPrice * rakiaCount) +
                                (beerPrice *beerCount) + 
                                (vinePrice * vineCount) +
                                (wiskiPrice * wiskiCount);

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
