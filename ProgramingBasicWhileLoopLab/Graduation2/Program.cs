using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string peopleName = Console.ReadLine();
            int counter = 0;
            int counterEvalution = 0;
            double evaluation = 0.0;
            bool stop = true;

            while (counter < 12)
            {
                double inputEvaluation = double.Parse(Console.ReadLine());
                
                if (inputEvaluation < 4.00)
                {
                    counterEvalution++;
                }
                else if (inputEvaluation >= 4.00)
                {
                    evaluation += inputEvaluation;
                    counter++;
                }
                if (counterEvalution == 2)
                {
                    counter++;
                    stop = false;
                    break;
                }
            }
            evaluation /= counter;
            if (!stop)
            {
                Console.WriteLine($"{peopleName} has been excluded at {counter} grade");
            }
            else

            {
                Console.WriteLine($"{peopleName} graduated. Average grade: {evaluation:f2}");
            }
        }
    }
}
