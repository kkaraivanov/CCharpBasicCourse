using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string restType = ""; // "Camp" и "Hotel"
            double priceForRest = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    restType = "Camp";
                    priceForRest = budget - budget * 0.70;
                }
                else if (season == "winter")
                {
                    restType = "Hotel";
                    priceForRest = budget - budget * 0.30;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    restType = "Camp";
                    priceForRest = budget - budget * 0.60;
                }
                else if (season == "winter")
                {
                    restType = "Hotel";
                    priceForRest = budget - budget * 0.20;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                restType = "Hotel";
                priceForRest = budget - budget * 0.10;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{restType} - {priceForRest:f2}");
        }
    }
}
