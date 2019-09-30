using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading (square, rectangle, circle или triangle).
            string figures = Console.ReadLine();
            double result = 0;

            switch (figures)
            {
                case "square":
                    double num = double.Parse(Console.ReadLine());
                    result = num * num;
                    Console.WriteLine($"{result:f3}");
                    break;
                case "rectangle":
                    double numA = double.Parse(Console.ReadLine());
                    double numB = double.Parse(Console.ReadLine());
                    result = numA * numB;
                    Console.WriteLine($"{result:f3}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    result = Math.PI * (radius * radius);
                    Console.WriteLine($"{result:f3}");
                    break;
                case "triangle":
                    double numC = double.Parse(Console.ReadLine());
                    double numHc = double.Parse(Console.ReadLine());
                    result = (numC * numHc) / 2;
                    Console.WriteLine($"{result:f3}");
                    break;
            }
        }
    }
}
