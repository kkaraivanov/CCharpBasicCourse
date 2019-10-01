using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string readWords = Console.ReadLine();

            if (readWords == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}