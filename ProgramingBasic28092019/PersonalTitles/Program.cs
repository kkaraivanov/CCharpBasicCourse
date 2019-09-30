using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();

            if (gender == "m")
            {
                if (years >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else
            {
                if (years >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
