using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora01
{
    public class Substract
    {
        public int firstNumber;
        public int secondNumber;
        public int resultSum;

        public Substract(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            resultSum = firstNumber - secondNumber;
            return resultSum;
        }
    }
}
