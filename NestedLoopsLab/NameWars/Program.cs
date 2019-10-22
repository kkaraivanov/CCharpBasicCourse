using System;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = "";
            int total = 0;
            while (true)
            {
                string curentNames = Console.ReadLine();
                char curentChar = ' ';
                int sum = 0;
                if (curentNames == "STOP")
                {
                    break;
                }
                for (int i = 0; i < curentNames.Length; i++)
                {
                    curentChar = curentNames[i];
                    sum += (int) curentChar;
                    if (sum > total)
                    {
                        names = curentNames;
                        total = sum;
                    }
                }
            }
            Console.WriteLine($"Winner is {names} - {total}!");
        }
    }
}
