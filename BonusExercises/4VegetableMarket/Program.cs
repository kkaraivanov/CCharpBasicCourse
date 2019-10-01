using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            const double euroValue = 1.94;

            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int quantityVegetable = int.Parse(Console.ReadLine());
            int quantityFruit = int.Parse(Console.ReadLine());

            double vegetable = quantityVegetable * vegetablePrice;
            double fruit = quantityFruit * fruitPrice;
            double result = (vegetable + fruit) / euroValue;

            Console.WriteLine($"{result:f2}");
        }
    }
}