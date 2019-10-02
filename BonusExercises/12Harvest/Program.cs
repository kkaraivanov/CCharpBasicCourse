using System;

namespace _12Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            int needVine = int.Parse(Console.ReadLine());
            int numberPeople = int.Parse(Console.ReadLine());

            double percentOf = 0.40;
            double grapesForLiterVine = 2.5;
            double kilogramOfGrapes =  vineyard * grapes;
            double literVine = (kilogramOfGrapes * percentOf) / grapesForLiterVine;

            if (literVine < needVine)
            {
                double result = Math.Floor(needVine - literVine);
                Console.WriteLine($"It will be a tough winter! More {result} liters wine needed.");
            }
            else if (literVine >= needVine)
            {
                double result = Math.Floor(literVine);
                double literForPeople = 0.0;
                Console.WriteLine($"Good harvest this year! Total wine: {result} liters.");
                result = Math.Ceiling(literVine - needVine);
                literForPeople = Math.Ceiling(result / numberPeople);
                Console.WriteLine($"{result} liters left -> {literForPeople} liters per person.");
            }
        }
    }
}
