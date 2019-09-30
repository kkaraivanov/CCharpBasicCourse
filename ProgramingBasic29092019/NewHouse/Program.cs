using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            const double roses = 5;
            const double dahlias = 3.80;
            const double tulips = 2.80;
            const double narcissus = 3;
            const double gladiolus = 2.50;

            string flower = Console.ReadLine();
            int countFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceForFlowers = 0.0;

            switch (flower)
            {
                case "Roses":
                    if (countFlowers > 80)
                    {
                        priceForFlowers = countFlowers * roses;
                        priceForFlowers *= 0.90;
                    }
                    else
                    {
                        priceForFlowers = countFlowers * roses;
                    }
                    break;
                case "Dahlias":
                    if (countFlowers > 90)
                    {
                        priceForFlowers = countFlowers * dahlias;
                        priceForFlowers *= 0.85;
                    }
                    else
                    {
                        priceForFlowers = countFlowers * dahlias;
                    }
                    break;
                case "Tulips":
                    if (countFlowers > 80)
                    {
                        priceForFlowers = countFlowers * tulips;
                        priceForFlowers *= 0.85;
                    }
                    else
                    {
                        priceForFlowers = countFlowers * tulips;
                    }
                    break;
                case "Narcissus":
                    if (countFlowers < 120)
                    {
                        priceForFlowers = countFlowers * narcissus;
                        priceForFlowers += (priceForFlowers * 0.15);
                    }
                    else
                    {
                        priceForFlowers = countFlowers * narcissus;
                    }
                    break;
                case "Gladiolus":
                    if (countFlowers < 80)
                    {
                        priceForFlowers = countFlowers * gladiolus;
                        priceForFlowers += (priceForFlowers * 0.20);
                    }
                    else
                    {
                        priceForFlowers = countFlowers * gladiolus;
                    }
                    break;
            }

            if (budget >= priceForFlowers)
            {
                priceForFlowers = budget - priceForFlowers;
                Console.WriteLine($"Hey, you have a great garden with {countFlowers} {flower} and {priceForFlowers:f2} leva left.");
            }
            else
            {
                priceForFlowers -= budget;
                Console.WriteLine($"Not enough money, you need {priceForFlowers:f2} leva more.");
            }
        }
    }
}
