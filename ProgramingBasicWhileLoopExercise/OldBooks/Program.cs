using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int valueLibrary = int.Parse(Console.ReadLine());

            string nextBookName = null;
            int counter = 1;

            while (true)
            {
                nextBookName = Console.ReadLine();
                if (nextBookName == bookName || counter == valueLibrary)
                {
                    break;
                }
                counter++;
            }

            if (bookName != nextBookName)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            else
            {
                Console.WriteLine($"You checked {counter - 1} books and found it.");
            }
        }
    }
}
