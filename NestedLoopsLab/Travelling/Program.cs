using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    return;
                }
                double sum = 0;
                double budget = double.Parse(Console.ReadLine());
                while (sum < budget)
                {
                    string currentS = Console.ReadLine();
                    if (currentS == "End")
                    {
                        return;
                    }
                    sum += double.Parse(currentS);

                    if (sum >= budget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                    }

                }
            }
        }
    }
}
