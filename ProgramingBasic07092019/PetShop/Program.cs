using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogCount = double.Parse(Console.ReadLine());
            double animallCount = double.Parse(Console.ReadLine());

            double dogPrice = dogCount * 2.50;
            double animallPrice = animallCount * 4;

            double totalPrice = dogPrice + animallPrice;

            Console.WriteLine($"{totalPrice:f} lv.");
        }
    }
}
