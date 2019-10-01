using System;

namespace StudyHall
{
    class Program
    {
        static void Main(string[] args)
        {
            const double loseWorkPosition = 3;

            double heighHall = double.Parse(Console.ReadLine());
            double widthHall = double.Parse(Console.ReadLine());

            double heigh = heighHall * 100;
            double width = widthHall * 100;
            double coridor = 100;
            double workPositionWidth = 70;
            double workPositionHeigh = 120;
            double rest = 0.0;

            //We find bureaus count at one row
            width -= coridor;
            rest = width % workPositionWidth;
            width -= rest;
            double bureauCount = width / workPositionWidth;

            //We find count at rows
            rest = heigh % workPositionHeigh;
            heigh -= rest;
            double rowCount = heigh / workPositionHeigh;

            //We find count work position
            double workPosition = (bureauCount * rowCount) - loseWorkPosition;

            Console.WriteLine(workPosition);
        }
    }
}