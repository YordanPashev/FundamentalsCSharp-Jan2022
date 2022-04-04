﻿using System;

namespace P12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            while (input % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(input)}");
        }
    }
}
