using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine(); // May, June, July, August, September или October
            int countNights = int.Parse(Console.ReadLine());

            double pricePerNightStudy = 0.0;
            double pricePerNightApartment = 0.0;

            if (month == "May" || month == "October")
            {
                pricePerNightStudy = countNights * 50;
                pricePerNightApartment = countNights * 65;
                if (countNights > 7 && countNights <= 14)
                {
                    pricePerNightStudy -= (pricePerNightStudy * 0.05);
                }
                else if (countNights > 14)
                {
                    pricePerNightStudy -= (pricePerNightStudy * 0.30);
                    pricePerNightApartment -= (pricePerNightApartment * 0.10);
                }
            }
            else if (month == "June" || month == "September")
            {
                pricePerNightStudy = countNights * 75.20;
                pricePerNightApartment = countNights * 68.70;
                if (countNights > 14)
                {
                    pricePerNightStudy -= (pricePerNightStudy * 0.20);
                    pricePerNightApartment -= (pricePerNightApartment * 0.10);
                }
            }
            else if (month == "July" || month == "August")
            {
                pricePerNightStudy = countNights * 76;
                pricePerNightApartment = countNights * 77;
                if (countNights > 14)
                {
                    pricePerNightApartment -= (pricePerNightApartment * 0.10);
                }
            }

            Console.WriteLine($"Apartment: {pricePerNightApartment:f2} lv.");
            Console.WriteLine($"Studio: {pricePerNightStudy:f2} lv.");
        }
    }
}
