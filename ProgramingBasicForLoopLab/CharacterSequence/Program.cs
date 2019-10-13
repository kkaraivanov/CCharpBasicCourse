using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string inString = Console.ReadLine();

            for (int i = 0; i < inString.Length; i++)
            {
                char courentChar = inString[i];
                Console.WriteLine(courentChar);
            }
        }
    }
}
