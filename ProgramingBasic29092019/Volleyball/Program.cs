using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            const int weekends = 48;

            string wordsYers = Console.ReadLine();
            double countHolidays = int.Parse(Console.ReadLine());
            double countWeekend = int.Parse(Console.ReadLine());

            double weekendInCity = weekends - countWeekend;
            double gamesInCity = (weekendInCity * 3) / 4;
            double gameOutCity = countWeekend;
            double gameInHolidays = (countHolidays * 2) / 3;
            
            double totalGames = gamesInCity + gameOutCity + gameInHolidays;
            
            if (wordsYers == "leap")
            {
                totalGames += (totalGames * 0.15); 
                totalGames = Math.Floor(totalGames);
            }
            else if (wordsYers == "normal")
            {
                totalGames = gamesInCity + gameOutCity + gameInHolidays;
                totalGames = Math.Floor(totalGames);
            }

            Console.WriteLine(totalGames);
        }
    }
}
