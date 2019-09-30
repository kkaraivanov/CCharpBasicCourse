using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int cakeCount = int.Parse(Console.ReadLine());
            int corrugationCount = int.Parse(Console.ReadLine());
            int pancakeCount = int.Parse(Console.ReadLine());

            double cakePrice = cakeCount * 45;
            double corrugationPrice = corrugationCount * 5.80;
            double pancakePrice = pancakeCount * 3.20;

            double totalCostPeple = cakePrice + corrugationPrice + pancakePrice;
            double totalCostForDay = totalCostPeple * peopleCount;
            double totalCostAllDay = totalCostForDay * dayCount;
            totalCostAllDay -= (totalCostAllDay / 8);

            Console.WriteLine($"{totalCostAllDay:F2}");
        }
    }
}
