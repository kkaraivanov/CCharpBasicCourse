using System;

namespace _16FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMagnolies = int.Parse(Console.ReadLine());
            int numberHyacinth = int.Parse(Console.ReadLine());
            int numberRoses = int.Parse(Console.ReadLine());
            int numberCactis = int.Parse(Console.ReadLine());
            double priceForGift = double.Parse(Console.ReadLine());

            double magnoliasPrice = 3.25;
            double hyacinthPrice = 4;
            double rosesPrice = 3.50;
            double cactisPrice = 8;
            double percentTaxes = 0.05;
            double priceForFlowers = (numberMagnolies * magnoliasPrice) +
                                     (numberHyacinth * hyacinthPrice) +
                                     (numberRoses * rosesPrice) +
                                     (numberCactis * cactisPrice);
            priceForFlowers = priceForFlowers - (priceForFlowers * percentTaxes);
            
            if (priceForFlowers >= priceForGift)
            {
                priceForGift = Math.Floor(priceForFlowers - priceForGift);
                Console.WriteLine($"She is left with {priceForGift} leva.");
            }
            else if(priceForFlowers < priceForGift)
            {
                priceForGift = Math.Ceiling(priceForGift - priceForFlowers);
                Console.WriteLine($"She will have to borrow {priceForGift} leva.");
            }
        }
    }
}
