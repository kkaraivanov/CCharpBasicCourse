using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double incoming = double.Parse(Console.ReadLine());

            double value = incoming * 100;
            int returnValueFerst = 0;
            int returnValueSecond = 0;
            int returnValueLast = 0;
            int diffLast = (int) value % 100;
            int diffFerst = (int) (value - diffLast) / 100;

            if (diffFerst >= 1 && diffFerst < 10)
            {
                if (diffFerst == 1 || diffFerst == 2)
                {
                    returnValueFerst = 1;
                }
                else if (diffFerst == 3 || diffFerst == 4)
                {
                    returnValueFerst = 2;
                }
                else if (diffFerst == 5 || diffFerst == 6)
                {
                    returnValueFerst = 3;
                }
                else if (diffFerst == 7 || diffFerst == 8)
                {
                    returnValueFerst = 4;
                }
                else
                {
                    returnValueFerst = 5;
                }
            }
            else
            {
                returnValueFerst = 0;
            }

            if (diffLast >= 10 && diffLast < 100)
            {
                int diff = (int) diffLast % 10;
                diffLast -= diff;

                if (diffLast == 10 || diffLast == 20 || diffLast == 50)
                {
                    returnValueLast = 1;
                }
                else if (diffLast == 30 || diffLast == 40 || diffLast == 60 || diffLast == 70)
                {
                    returnValueLast = 2;
                }
                else if (diffLast == 80 || diffLast == 90)
                {
                    returnValueLast = 3;
                }
                if (diff == 1 || diff == 2 || diff == 5)
                {
                    returnValueSecond = 1;
                }
                else if (diff == 3 || diff == 4 || diff == 6 || diff == 7)
                {
                    returnValueSecond = 2;
                }
                else if(diff == 8 || diff == 9)
                {
                    returnValueSecond = 3;
                }
            }

            Console.WriteLine($"{returnValueFerst+ returnValueLast + returnValueSecond}");
        }
    }
}
