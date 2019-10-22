using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int curentNum = int.Parse(number[i].ToString());
                if (curentNum == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                curentNum += 33;
                char myChar = (char)curentNum;
                for (int j = 0; j < curentNum - 33; j++)
                {
                    Console.Write(myChar);
                }
                Console.WriteLine();
            }
        }
    }
}
