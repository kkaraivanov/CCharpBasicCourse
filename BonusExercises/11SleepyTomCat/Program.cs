using System;

namespace _11SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOffDay = int.Parse(Console.ReadLine());
            int playNorm = 30000;
            int normAtWork = 63;
            int normAtOffDay = 127;
            int yearDay = 365;
            int constOneHour = 60;

            int workDay = yearDay - numberOffDay;
            int playAtWorkDay = workDay * normAtWork; // in minutes
            int playAtOffDay = numberOffDay * normAtOffDay; // in minutes
            int differenceMinute = playNorm - (playAtWorkDay + playAtOffDay);
            int hour = Math.Abs(differenceMinute / constOneHour);
            int minutes = Math.Abs(differenceMinute % constOneHour);

            if (playAtWorkDay + playAtOffDay > playNorm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hour} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hour} hours and {minutes} minutes less for play");
            }
        }
    }
}
