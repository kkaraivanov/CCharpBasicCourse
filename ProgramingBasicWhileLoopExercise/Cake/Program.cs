using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthCake = int.Parse(Console.ReadLine());
            int lengthCake = int.Parse(Console.ReadLine());

            int sizeCake = widthCake * lengthCake;
            int sliceCount = 0;

            while (true)
            {
                string slice = Console.ReadLine();

                if (slice == "STOP")
                {
                    break;
                }
                else
                {
                    sliceCount += int.Parse(slice);
                }
                if (sliceCount >= sizeCake)
                {
                    break;
                }
            }
            if (sliceCount <= sizeCake)
            {
                sliceCount = sizeCake - sliceCount;
                Console.WriteLine($"{sliceCount} pieces are left.");
            }
            else
            {
                sliceCount -= sizeCake;
                Console.WriteLine($"No more cake left! You need {sliceCount} pieces more.");
            }
        }
    }
}
