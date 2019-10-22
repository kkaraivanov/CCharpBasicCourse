using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int ferstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = ferstNum; i <= secondNum; i++)
            {
                string a = i.ToString();
                int even = 0;
                int odd = 0;
                
                for (int j = a.Length - 1; j >= 0; j--)
                {
                    char curent = a[j];
                    int curentDigit = int.Parse(curent.ToString());
                    if (j % 2 == 0)
                    {
                        even += int.Parse(curentDigit.ToString());
                    }
                    else
                    {
                        odd += int.Parse(curentDigit.ToString());
                    }
                }
                if (even == odd)
                {
                    Console.Write(a + " ");
                }
            }
        }
    }
}
