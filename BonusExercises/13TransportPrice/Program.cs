using System;

namespace _13TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberKilometers = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double taxiFee = 0.70;
            double taxiDayFee = 0.79;
            double taxiNightFee = 0.90;
            double autobussFee = 0.09; // distace up 20 km
            double trainFee = 0.06; // distance up 100 km
            double paymentAmount = 0.0;

            if (numberKilometers < 20)
            {
                if (dayOrNight == "day")
                {
                    paymentAmount = taxiFee + (taxiDayFee * numberKilometers);
                }
                else if (dayOrNight == "night")
                {
                    paymentAmount = taxiFee + (taxiNightFee * numberKilometers);
                }
            }
            else if (numberKilometers >= 20 && numberKilometers < 100)
            {
                paymentAmount = autobussFee * numberKilometers;
            }
            else if (numberKilometers >= 100)
            {
                paymentAmount = trainFee * numberKilometers;
            }

            Console.WriteLine($"{paymentAmount:f2}");
        }
    }
}
