using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            double counter = 0;
            double grade = 0.0;
            while (true)
            {
                string inputString = Console.ReadLine();
                double curentGrade = 0.0;
                if (inputString == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {grade/counter:f2}.");
                    return;
                }
                for (int i = 0; i < peopleNumber; i++)
                {
                    curentGrade += double.Parse(Console.ReadLine());
                }
                grade += curentGrade;
                counter += peopleNumber;
                Console.WriteLine($"{inputString} - {curentGrade / peopleNumber:f2}.");
            }
        }
    }
}
