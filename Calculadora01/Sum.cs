using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora01
{
    public class Sum
    {
        public int firstNumber;
        public int secondNumber;
        public int resultSum;

        public Sum(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            resultSum = firstNumber + secondNumber;
            return resultSum;
        }

        public int Undo()
        {
            return resultSum - secondNumber;
        }
    }
}
