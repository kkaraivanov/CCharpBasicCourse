using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double numberToCantimeter = number * 2.54;

            Console.WriteLine(numberToCantimeter.ToString("F"));
        }
    }
}
