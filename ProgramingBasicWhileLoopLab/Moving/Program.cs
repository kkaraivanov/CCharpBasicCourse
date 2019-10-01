using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());

            int space = widthFreeSpace * lengthFreeSpace * heightFreeSpace;
            int boxes = 0;
            string command = null;

            while (true)
            {
                command = Console.ReadLine();
                if (command != "Done")
                {
                    boxes += int.Parse(command);
                }
                else
                {
                    break;
                }
                
                if (boxes >= space)
                {
                    break;
                }
            }
            if (space > boxes)
            {
                Console.WriteLine($"{space - boxes} Cubic meters left.");
            }
            else if (boxes >= space)
            {
                Console.WriteLine($"No more free space! You need {boxes - space} Cubic meters more.");
            }
        }
    }
}
