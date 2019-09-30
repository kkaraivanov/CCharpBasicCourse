using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFerst = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if (numFerst > numTwo)
            {
                Console.WriteLine(numFerst);
            }
            else
            {
                Console.WriteLine(numTwo);
            }
        }
    }
}
