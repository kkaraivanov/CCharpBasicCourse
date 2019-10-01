using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string peopleName = Console.ReadLine();
            int counter = 0;
            double evaluation = 0.0;

            while (counter < 12)
            {
                double inputEvaluation = double.Parse(Console.ReadLine());
                if (inputEvaluation < 4.00)
                {
                    continue;
                }
                else if (inputEvaluation >= 4.00)
                {
                    evaluation += inputEvaluation;
                    counter++;
                }
            }
            evaluation /= counter;
            Console.WriteLine($"{peopleName} graduated. Average grade: {evaluation:f2}");
        }
    }
}
