using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora01
{
    internal class CalculatorProgram
    {
        public int Sum(int firstnumber, int secondNumber) 
        {
            return firstnumber + secondNumber;   
        }
        public int Substract(int firstnumber, int secondNumber)
        {
            return firstnumber - secondNumber;
        }
        public int Multiply(int firstnumber, int secondNumber)
        {
            return firstnumber * secondNumber;
        }
        public int Divide(int firstnumber, int secondNumber)
        {
            return firstnumber / secondNumber;
        }

        static void Main(string[] args)
        {
            var calculatorProgram = new CalculatorProgram();

            var sumOne = new Sum(1, 2);
            var sumSecond = new Sum(sumOne.Perform(), 8);
            var sumThird = new Sum(sumSecond.Perform(), 9);
            Console.WriteLine(sumThird.Perform());
            var resultAfterUndo = sumThird.Undo();

            Console.WriteLine("------------------------");
            Console.WriteLine(resultAfterUndo);
            Console.WriteLine("------------------------");


            var respSum = calculatorProgram.Sum(1, 2);
            respSum = calculatorProgram.Sum(respSum, 8);
            respSum = calculatorProgram.Sum(respSum, 9);

            var respSubstract = calculatorProgram.Substract(4, 2);
            var respMultiply = calculatorProgram.Multiply(3, 7);
            var respDivide = calculatorProgram.Divide(3, 2);
        }
    }
}
