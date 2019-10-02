using System;

namespace _17FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine(); // "Diesel", "Gasoline", "Gas"
            double litersFuel = double.Parse(Console.ReadLine()); // available in tank
            int constLiters = 25;

            switch (fuelType)
            {
                case "Diesel":
                case "Gasoline":
                case "Gas":
                    if (litersFuel >= constLiters)
                    {
                        Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                    }
                    else if (litersFuel < constLiters)
                    {
                        Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }
        }
    }
}
