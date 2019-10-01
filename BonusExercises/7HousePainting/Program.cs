using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightHouse = double.Parse(Console.ReadLine());
            double lengthHouse = double.Parse(Console.ReadLine());
            double heightHouseTriangle = double.Parse(Console.ReadLine());

            double wSide = 0.0;
            double hSide = 0.0;

            // 2 square walls
            wSide = 1.2;
            hSide = 2;
            double door = wSide * hSide;
            double squareWall = (heightHouse * heightHouse - door) + (heightHouse * heightHouse);
            // 2 rectangular walls
            wSide = 1.5;
            hSide = 1.5;
            double window = wSide * hSide;
            double rectangularWall = (lengthHouse * heightHouse - window) * 2;
            // roof
            double roofRectangular = (lengthHouse * heightHouse) * 2;
            double triangleRoof = ((heightHouse * heightHouseTriangle) / 2) * 2;
            // total area walls and roof
            double wallArea = squareWall + rectangularWall;
            double roofArea = roofRectangular + triangleRoof;

            double greenColor = wallArea / 3.4;
            double redColor = roofArea / 4.3;

            Console.WriteLine($"{greenColor:f2}");
            Console.WriteLine($"{redColor:f2}");
        }
    }
}