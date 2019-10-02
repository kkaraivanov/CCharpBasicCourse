using System;

namespace _10PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volumePool = int.Parse(Console.ReadLine());
            int flowRatPipeOne = int.Parse(Console.ReadLine());
            int flowRatPipeTwo = int.Parse(Console.ReadLine());
            double workerOutTime = double.Parse(Console.ReadLine());

            double pipeOne = flowRatPipeOne * workerOutTime;
            double pipeTwo = flowRatPipeTwo * workerOutTime;
            double totalPool = pipeOne + pipeTwo;
            double chekPool = 0;
            if (totalPool > volumePool)
            {
                chekPool = totalPool - volumePool;
            }
            pipeOne = (pipeOne / totalPool) * 100;
            pipeTwo = (pipeTwo / totalPool) * 100;
            totalPool = (totalPool / volumePool) * 100;

            if (chekPool == 0)
            {
                Console.WriteLine($"The pool is {totalPool:f2}% full. Pipe 1: {pipeOne:f2}%. Pipe 2: {pipeTwo:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {workerOutTime} hours the pool overflows with {chekPool:f2} liters.");
            }
        }
    }
}
