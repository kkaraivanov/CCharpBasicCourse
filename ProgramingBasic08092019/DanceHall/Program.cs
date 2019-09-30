using System;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            const int cmValue = 100;
            const int peopleArea = 40;
            const int needFreeSpace = 7000;

            double lSite = double.Parse(Console.ReadLine()) * cmValue;
            double wSite = double.Parse(Console.ReadLine()) * cmValue;
            double aSite = double.Parse(Console.ReadLine()) * cmValue;

            double hallArea = lSite * wSite;
            double wardrobeArea = aSite * aSite;
            double benchArea = hallArea / 10;

            double freeSpaceArea = hallArea - wardrobeArea - benchArea;
            double totalPeople = Math.Floor(freeSpaceArea / (peopleArea + needFreeSpace));

            Console.WriteLine(totalPeople);
        }
    }
}
