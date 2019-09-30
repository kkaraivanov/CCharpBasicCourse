using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double readR = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * readR * readR;
            double circlePerimeter = 2 * Math.PI * readR;

            Console.WriteLine(circleArea.ToString("F"));
            Console.WriteLine(circlePerimeter.ToString("F"));
        }
    }
}
