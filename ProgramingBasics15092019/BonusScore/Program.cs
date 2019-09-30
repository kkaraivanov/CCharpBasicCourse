using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointCount = int.Parse(Console.ReadLine());

            double bonusPoint = 0;

            if (pointCount <= 100)
            {
                bonusPoint = 5;
            }
            else if (pointCount > 100 && pointCount < 1000)
            {
                bonusPoint = pointCount * 0.20;
            }
            else if (pointCount > 1000)
            {
                bonusPoint = pointCount * 0.10;
            }
            
            if (pointCount % 2 == 0)
            {
                bonusPoint += 1;
            }
            else if (pointCount % 5 == 0)
            {
                bonusPoint += 2;
            }

            double result = pointCount + bonusPoint;
            Console.WriteLine(bonusPoint);
            Console.WriteLine(result);
        }
    }
}
