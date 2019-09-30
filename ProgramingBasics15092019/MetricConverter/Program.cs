using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            double mm = 0;

            if (from == "m")
            {
                mm = amount * 1000;
            }
            else if (from == "cm")
            {
                mm = amount * 10;
            }
            else if (from == "mm")
            {
                mm = amount;
            }

            if (to == "m")
            {
                amount = mm / 1000;
            }
            else if (to == "cm")
            {
                amount = mm / 10;
            }
            else if (to == "mm")
            {
                amount = mm;
            }

            Console.WriteLine($"{amount:F3}");
        }
    }
}
