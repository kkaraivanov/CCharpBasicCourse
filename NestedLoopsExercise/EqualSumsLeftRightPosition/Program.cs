using System;

namespace EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int ferstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = ferstNum; i <= secondNum; i++)
            {
                string curentNum = i.ToString();
                int leftNum = 0;
                int rightNum = 0;
                int averageNum = 0;
                for (int j = 0; j < curentNum.Length; j++)
                {
                    if (j < 2)
                    {
                        leftNum += int.Parse((curentNum[j]).ToString());
                    }
                    else if (j >=2 && j < 3)
                    {
                        averageNum = int.Parse((curentNum[j]).ToString());
                    }
                    else
                    {
                        rightNum += int.Parse((curentNum[j]).ToString());
                    }
                }
                if (leftNum == rightNum)
                {
                    Console.Write(curentNum + " ");
                }
                else
                {
                    if (leftNum < rightNum)
                    {
                        leftNum += averageNum;
                    }
                    else
                    {
                        rightNum += averageNum;
                    }
                    if (leftNum == rightNum)
                    {
                        Console.Write(curentNum + " ");
                    }
                }
            }
        }
    }
}
