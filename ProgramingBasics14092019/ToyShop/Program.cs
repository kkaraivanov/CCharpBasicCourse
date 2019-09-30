﻿using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzelPrice = 2.60;
            const double dolsPrice = 3;
            const double bearsPrice = 4.10;
            const double minionsPrice = 8.20;
            const double carsPrice = 2;

            double priceExcursie = double.Parse(Console.ReadLine());
            int puzelsCount = int.Parse(Console.ReadLine());
            int dolsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int carsCount = int.Parse(Console.ReadLine());

            double totalPriceToys = (puzelsCount * puzelPrice) +
                                    (dolsCount * dolsPrice) +
                                    (bearsCount * bearsPrice) +
                                    (minionsCount * minionsPrice) +
                                    (carsCount * carsPrice);
            double totalCountToys = puzelsCount + dolsCount + bearsCount + minionsCount + carsCount;
            double discount = totalPriceToys * 0.25;
            double rent = 0;
            double restMoney = 0;

            if (totalCountToys >= 50)
            {
                totalPriceToys -= discount;
                rent = totalPriceToys * 0.10;
                restMoney = totalPriceToys - rent;
            }
            else
            {
                rent = totalPriceToys * 0.10;
                restMoney = totalPriceToys - rent;
            }
            double result = 0;
            if (restMoney >= priceExcursie)
            {
                result = restMoney - priceExcursie;
                Console.WriteLine($"Yes! {result:f2} lv left.");
            }
            else
            {
                result = priceExcursie - restMoney;
                Console.WriteLine($"Not enough money! {result:f2} lv needed.");
            }
        }
    }
}
