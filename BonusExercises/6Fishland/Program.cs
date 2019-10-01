using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double chamoisKilogram = double.Parse(Console.ReadLine());
            double scadKilogram = double.Parse(Console.ReadLine());
            double musselsKilogram = double.Parse(Console.ReadLine());

            double percent = 0.0;
            // 60% from mackerel
            percent = mackerelPrice * 0.60;
            double chamoisPrice = mackerelPrice + percent;  // 60% more expensive than mackerel 
            // 80% from sprat
            percent = spratPrice * 0.80;
            double scadPrice = spratPrice + percent; // 80% more expensive than sprat
            double musselsPrice = 7.50;

            double formedPrice = (chamoisKilogram * chamoisPrice) +
                                 (scadKilogram * scadPrice) +
                                 (musselsKilogram * musselsPrice);
            Console.WriteLine($"{formedPrice:f2}");
        }
    }
}