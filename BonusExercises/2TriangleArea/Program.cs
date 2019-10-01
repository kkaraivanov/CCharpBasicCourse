using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double aSite = double.Parse(Console.ReadLine());
            double hSite = double.Parse(Console.ReadLine());

            double result = aSite * hSite / 2;

            Console.WriteLine($"{result:f2}");
        }
    }
}