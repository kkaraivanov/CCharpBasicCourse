using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int ferstNum = int.Parse(Console.ReadLine());
            int lastNum = int.Parse(Console.ReadLine());
            int thredNum = int.Parse(Console.ReadLine());

            int tottalTime = ferstNum + lastNum + thredNum;
            int minutes = tottalTime / 60;
            int seconds = tottalTime % 60;

            Console.WriteLine($"{minutes}:{seconds:D2}");
        }
    }
}
