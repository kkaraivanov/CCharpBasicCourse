using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double income = row * col;

            if (type == "Premiere")
            {
                income *= 12.00;
            }
            else if (type == "Normal")
            {
                income *= 7.50;
            }
            else if (type == "Discount")
            {
                income *= 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
