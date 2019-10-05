using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());

            int spendCounter = 0;
            int dayCounter = 0;

            while (ownedMoney < needMoney && spendCounter < 5)
            {
                string stepType = Console.ReadLine();
                double spendOrSaveMoney = double.Parse(Console.ReadLine());
                if (stepType == "spend")
                {
                    if (spendOrSaveMoney > ownedMoney)
                    {
                        ownedMoney = 0;
                        spendCounter++;
                    }
                    else
                    {
                        ownedMoney -= spendOrSaveMoney;
                        spendCounter++;
                    }
                }
                else if (stepType == "save")
                {
                    ownedMoney += spendOrSaveMoney;
                    spendCounter = 0;
                }
                if (ownedMoney < 0)
                {
                    ownedMoney = 0;
                }
                dayCounter++;
            }

            if (spendCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{dayCounter}");
            }
            else if (ownedMoney >= needMoney)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }
        }
    }
}
