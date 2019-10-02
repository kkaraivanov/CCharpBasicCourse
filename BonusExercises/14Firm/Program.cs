using System;

namespace _14Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int availableHours = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int numberPersons = int.Parse(Console.ReadLine());

            double percentForLearn = 0.10;
            double learnDays = availableDays * percentForLearn;
            double workHour = 0.0;
            int workDay = 8;
            int afterHoursForProject = 2;

            workHour = (availableDays - learnDays) * workDay;
            workHour += (numberPersons * (availableDays * afterHoursForProject));
            workHour = Math.Floor(workHour);

            if (availableHours <= workHour)
            {
                int result = (int) (workHour - availableHours);
                Console.WriteLine($"Yes!{result} hours left.");
            }
            else if(availableHours > workHour)
            {
                int result = (int)(availableHours - workHour);
                Console.WriteLine($"Not enough time!{result} hours needed.");
            }
        }
    }
}
