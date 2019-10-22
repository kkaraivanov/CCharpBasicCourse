using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int ferstRowFerstNum = a; ferstRowFerstNum <= b; ferstRowFerstNum++)
            {
                for (int ferstRowSecondNum = a; ferstRowSecondNum <= b; ferstRowSecondNum++)
                {
                    for (int secondRowFerstNum = c; secondRowFerstNum <= d; secondRowFerstNum++)
                    {
                        for (int secondRowSecondNum = c; secondRowSecondNum <= d; secondRowSecondNum++)
                        {
                            if ((ferstRowFerstNum + secondRowSecondNum) == (ferstRowSecondNum + secondRowFerstNum) &&
                                (ferstRowFerstNum != ferstRowSecondNum) && (secondRowFerstNum != secondRowSecondNum))
                            {
                                Console.WriteLine($"{ferstRowFerstNum}{ferstRowSecondNum}");
                                Console.WriteLine($"{secondRowFerstNum}{secondRowSecondNum}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
