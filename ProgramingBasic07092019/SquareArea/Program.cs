﻿using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());

            side *= side;
            Console.WriteLine(side);
        }
    }
}
