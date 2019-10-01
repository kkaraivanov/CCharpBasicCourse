using System;

namespace SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double aSite = double.Parse(Console.ReadLine());
            double bSite = double.Parse(Console.ReadLine());
            double hSite = double.Parse(Console.ReadLine());

            double result = (aSite + bSite) * hSite / 2;

            Console.WriteLine($"{result:f2}");
        }
    }
}