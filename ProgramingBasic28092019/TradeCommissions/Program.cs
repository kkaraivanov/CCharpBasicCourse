﻿using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double quality = double.Parse(Console.ReadLine());
            double price = 0.0;
            bool validateCity = true;

            if (city == "Sofia")
            {
                price += quality;
                
                if (quality >= 0 && quality <= 500)
                {
                    price *= 0.05;
                }
                else if (quality > 500 && quality <= 1000)
                {
                    price *= 0.07;
                }
                else if (quality > 1000 && quality <= 10000)
                {
                    price *= 0.08;
                }
                else if (quality > 10000)
                {
                    price *= 0.12;
                }
                else
                {
                    price = -1;
                }
            }
            else if (city == "Varna")
            {
                price += quality;

                if (quality >= 0 && quality <= 500)
                {
                    price *= 0.045;
                }
                else if (quality > 500 && quality <= 1000)
                {
                    price *= 0.075;
                }
                else if (quality > 1000 && quality <= 10000)
                {
                    price *= 0.1;
                }
                else if (quality > 10000)
                {
                    price *= 0.13;
                }
                else
                {
                    price = -1;
                }
            }
            else if (city == "Plovdiv")
            {
                price += quality;

                if (quality >= 0 && quality <= 500)
                {
                    price *= 0.055;
                }
                else if (quality > 500 && quality <= 1000)
                {
                    price *= 0.08;
                }
                else if (quality > 1000 && quality <= 10000)
                {
                    price *= 0.12;
                }
                else if (quality > 10000)
                {
                    price *= 0.145;
                }
                else
                {
                    price = -1;
                }
            }
            else
            {
                validateCity = false;
            }

            if (!validateCity || price < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
