using Modul10.Final2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Final2
{
    
    public interface ICalculator
    {
        int Add(int numA, int numB);
    }
    
    public class Calculator : ICalculator
    {
        public ILogger logger;

        public Calculator()
        {
            logger = new ConsoleLogger();
        }

        public Calculator(string filePath)
        {
            logger = new FileLogger(filePath);
        }

        private int EnterNumber(string numName)
        {
            int number;
            while (true)
            {
                try
                {
                    logger.Info($"Type number {numName} and press Enter: ");
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    logger.Error("Incorrect input: " + e.ToString());
                }
            }
            return number;
        }

        public int Add(int numA, int numB)
        {
            return numA + numB;
        }

        public void Add()
        {
            int numA = EnterNumber("1 (A)");
            int numB = EnterNumber("2 (B)");

            int result = numA + numB;
            logger.Event($"Result of addiction {numA} and {numB} is {result}");
        }

    }
}
