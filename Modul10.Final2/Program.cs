using System;

namespace Modul10.Final2
{
    internal class Program
    {
        static ConsoleLogger log = new ConsoleLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("MiniCalc (addiction only)");

            Calculator calc = new Calculator();
            calc.Add();

            Console.WriteLine("That's all! Goodbye!!!");
        }
    }
}
