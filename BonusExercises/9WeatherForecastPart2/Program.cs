using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());

            if (degree >= 26.00 && degree <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (degree > 20.00 && degree < 26.00)
            {
                Console.WriteLine("Warm");
            }
            else if (degree >= 15.00 && degree <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degree >= 12.00 && degree < 15.00)
            {
                Console.WriteLine("Cool");
            }
            else if (degree >= 5.00 && degree < 12.00)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}