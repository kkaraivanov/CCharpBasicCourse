using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomePrice = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());

            double scholarship = Math.Floor(minimumSalary * 0.35);
            double theBestSuccess = Math.Ceiling(averageSuccess * 25);
            double printEscelentScholership = 0;

            if (scholarship > theBestSuccess)
            {
                printEscelentScholership = scholarship;
            }
            else
            {
                printEscelentScholership = theBestSuccess;
            }

            if (incomePrice <= minimumSalary && averageSuccess > 4.5 && averageSuccess < 5.5)
            {
                Console.WriteLine($"You get a Social scholarship {scholarship} BGN");
            }
            else if (incomePrice <= minimumSalary && averageSuccess >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {printEscelentScholership} BGN");
            }
            else if (incomePrice > minimumSalary && averageSuccess >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {theBestSuccess} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
    public class MyClas
    {
        public MyClas(int myInt)
        {
            // logic and code for him
        }
    }

}
