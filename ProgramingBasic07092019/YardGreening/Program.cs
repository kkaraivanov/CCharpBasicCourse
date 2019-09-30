using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double greeningYards = double.Parse(Console.ReadLine());

            double oneMeterPrice = 7.61; //стойност на 1 кв метър със ДДС
            double discountPrice = 0.18; // отстъпка от общата цена
            double needMoney = 0; // колко средства са необходими

            needMoney = greeningYards * oneMeterPrice;
            discountPrice = needMoney * discountPrice;
            needMoney -= discountPrice;

            Console.WriteLine($"The final price is: {needMoney:f2} lv.");
            Console.WriteLine($"The discount is: {discountPrice:f2} lv.");
        }
    }
}
