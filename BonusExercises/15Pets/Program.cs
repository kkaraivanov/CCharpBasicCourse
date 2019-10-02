using System;

namespace _15Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDays = int.Parse(Console.ReadLine());
            int foodsValue = int.Parse(Console.ReadLine());
            double dogEatPerDay = double.Parse(Console.ReadLine());
            double catEatPerDay = double.Parse(Console.ReadLine());
            double turtleEatPerDay = double.Parse(Console.ReadLine());

            double totalFoodNeed = (dogEatPerDay * numberDays) +
                                   (catEatPerDay * numberDays) +
                                   ((turtleEatPerDay * numberDays) / 1000);
            if (foodsValue >= totalFoodNeed)
            {
                totalFoodNeed = Math.Floor(foodsValue - totalFoodNeed);
                Console.WriteLine($"{totalFoodNeed} kilos of food left.");
            }
            else
            {
                totalFoodNeed = Math.Ceiling(totalFoodNeed - foodsValue);
                Console.WriteLine($"{totalFoodNeed} more kilos of food are needed.");
            }
        }
    }
}
