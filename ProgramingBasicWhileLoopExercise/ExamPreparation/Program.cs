using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberEstimates = int.Parse(Console.ReadLine());
            //--------------------next ---->>>>>
            string taskName = Console.ReadLine();
            int estimates = int.Parse(Console.ReadLine());

            string word = "Enough";
            string lastTask = null;
            int breakEstimates = 0;
            int counter = 1;
            double totalEstimates = estimates;

            if (estimates <= 4)
            {
                breakEstimates++;
            }

            while (true)
            {
                taskName = Console.ReadLine();
                if (taskName != word)
                {
                    lastTask = taskName;
                }
                if (taskName == word)
                {
                    break;
                }

                estimates = int.Parse(Console.ReadLine());
                if (estimates <= 4)
                {
                    breakEstimates++;
                }

                if (breakEstimates == numberEstimates)
                {
                    break;
                }

                totalEstimates += estimates;
                counter++;
            }

            if (taskName == word)
            {
                totalEstimates /= counter;
                Console.WriteLine($"Average score: {totalEstimates:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
            else
            {
                Console.WriteLine($"You need a break, {breakEstimates} poor grades.");
            }
        }
    }
}
