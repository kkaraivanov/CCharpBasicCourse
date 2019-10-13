using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double restSalary = salary;
            double facebookForfeit = 150;
            double instagramForfeit = 100;
            double redditForfeit = 50;

            for (int i = 0; i < numberTabs && restSalary > 0; i++)
            {
                string sites = Console.ReadLine();
                
                if (sites == "Facebook")
                {
                    restSalary -=  facebookForfeit;
                }
                else if (sites == "Instagram")
                {
                    restSalary -= instagramForfeit;
                }
                else if (sites == "Reddit")
                {
                    restSalary -= redditForfeit;
                }
            }
            if (restSalary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine((int)restSalary);
            }
        }
    }
}
