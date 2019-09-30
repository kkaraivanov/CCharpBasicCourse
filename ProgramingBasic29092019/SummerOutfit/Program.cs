using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradus = int.Parse(Console.ReadLine());
            string timeFromDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (timeFromDay == "Morning")
            {
                if (gradus >= 10 && gradus <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (gradus > 18 && gradus <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (gradus >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (timeFromDay == "Afternoon")
            {
                if (gradus >= 10 && gradus <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (gradus > 18 && gradus <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (gradus >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (timeFromDay == "Evening")
            {
                if (gradus >= 10 && gradus <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (gradus > 18 && gradus <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (gradus >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
        }
    }
}
