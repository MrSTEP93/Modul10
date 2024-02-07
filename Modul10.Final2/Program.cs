using System;

namespace Modul10.Final2
{
    internal class Program
    {
        ConsoleLogger log = new ConsoleLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        private static int EnterNumber(string numName)
        {
            int number;
            while (true)
            {
                try
                {
                    log.($"Type number {numName} and press Enter: ");
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
