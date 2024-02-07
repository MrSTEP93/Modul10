using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Final
{
    
    public interface ICalculator
    {
        int Add(int numA, int numB);
    }
    
    public class Calculator : ICalculator
    {
        public int Add(int numA, int numB)
        {
            return numA + numB;
        }
    }
}
