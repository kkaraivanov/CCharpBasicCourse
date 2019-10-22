using System;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberFishPerDay = int.Parse(Console.ReadLine());
            int counter = 0;
            int curentFish = 0;
            double payPrice = 0.00;
            double wonPrice = 0.00;
            
            while (true)
            {
                string fisheName = Console.ReadLine();
                if (fisheName == "Stop")
                {
                    break;
                }

                double kilogramsOfFish = double.Parse(Console.ReadLine());
                double priceForFish = 0;
                counter++;
                for (int j = 0; j < fisheName.Length; j++)
                {
                    char curentChar = fisheName[j];
                    priceForFish += curentChar;
                }

                curentFish++;
                if (curentFish == 3)
                {
                    wonPrice += (priceForFish / kilogramsOfFish);
                    curentFish = 0;
                }
                else
                {
                    payPrice += (priceForFish / kilogramsOfFish);
                }
                if (counter >= numberFishPerDay)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }
            }
            
            if (wonPrice > payPrice)
            {
                wonPrice -= payPrice;
                Console.WriteLine($"Lyubo's profit from {counter} fishes is {wonPrice:f2} leva.");
            }
            else
            {
                payPrice -= wonPrice;
                Console.WriteLine($"Lyubo lost {payPrice:f2} leva today.");
            }
        }
    }
}
