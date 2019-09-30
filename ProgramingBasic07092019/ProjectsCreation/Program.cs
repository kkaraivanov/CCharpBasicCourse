using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string arhitectName = Console.ReadLine();
            int countHours = int.Parse(Console.ReadLine());

            int projectCount = countHours * 3;

            Console.WriteLine($"The architect {arhitectName} will need {projectCount} hours to complete {countHours} project/s.");
        }
    }
}
