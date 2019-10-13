using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int result = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                char courentChar = inputString[i];

                switch (courentChar)
                {
                    case 'a':
                        result += 1;
                        break;
                    case 'e':
                        result += 2;
                        break;
                    case 'i':
                        result += 3;
                        break;
                    case 'o':
                        result += 4;
                        break;
                    case 'u':
                        result += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
