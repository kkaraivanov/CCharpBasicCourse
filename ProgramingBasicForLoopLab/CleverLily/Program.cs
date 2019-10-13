using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toysPrice = int.Parse(Console.ReadLine());

            int money = 0;
            int brotherMoney = 0;
            int toys = 0;
            double resultMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    resultMoney += money;
                    brotherMoney++;
                }
                else
                {
                    toys++;
                }
            }

            resultMoney += (toysPrice * toys) - brotherMoney;

            if (resultMoney >= washingMachinePrice)
            {
                resultMoney = Math.Abs(resultMoney - washingMachinePrice);
                Console.WriteLine($"Yes! {resultMoney:f2}");
            }
            else
            {
                resultMoney = Math.Abs(washingMachinePrice - resultMoney);
                Console.WriteLine($"No! {resultMoney:f2}");
            }
        }
    }
}
