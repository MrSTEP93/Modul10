﻿using System;

namespace Modul10.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MiniCalc (addiction only)");
            int a = EnterNumber("1 (A)");
            int b = EnterNumber("2 (B)");

            Calculator calc = new Calculator();
            int result = calc.Add(a, b);
            Console.WriteLine($"Result of addiction {a} and {b} is { result }");

        }

        private static int EnterNumber(string numName)
        {
            int number;
            while (true)
            {
                try
                {
                    Console.Write($"Type number {numName} and press Enter: ");
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Incorrect input: " + e.ToString());
                }
            }
            return number;
        }
    }
}
