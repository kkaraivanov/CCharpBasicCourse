using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputCelsius = double.Parse(Console.ReadLine());

            double resultFarenhaid = inputCelsius * 1.8 + 32; //°F = °C × 1,8 + 32

            Console.WriteLine($"{resultFarenhaid:f2}");
        }
    }
}