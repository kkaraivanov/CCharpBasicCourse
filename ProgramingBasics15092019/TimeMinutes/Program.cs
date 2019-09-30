using System;

namespace TimeMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            switch (minutes)
            {
                case 01:
                    minutes = 1;
                    break;
                case 02:
                    minutes = 2;
                    break;
                case 03:
                    minutes = 3;
                    break;
                case 04:
                    minutes = 4;
                    break;
                case 05:
                    minutes = 5;
                    break;
                case 06:
                    minutes = 6;
                    break;
                case 07:
                    minutes = 7;
                    break;
                case 08:
                    minutes = 8;
                    break;
                case 09:
                    minutes = 9;
                    break;
            }
            minutes += 15;

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }
            else
            {
                minutes = minutes;
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            else
            {
                hours = hours;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
