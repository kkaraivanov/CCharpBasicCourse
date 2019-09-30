﻿using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double lenght = Math.Abs(x1 - y1);
            double width = Math.Abs(x2 - y2);

            double area = lenght * width;
            double perimeter = 2 * (lenght + width);

            Console.WriteLine($"{area:F2}");
            Console.WriteLine($"{perimeter:F2}");
        }
    }
}
