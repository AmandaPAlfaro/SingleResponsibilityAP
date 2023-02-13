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
            Console.WriteLine("");
            Console.WriteLine("-----------Substract-------------");
            var subOne = new Substract(10, 2);
            var subSecond = new Substract(subOne.Perform(), 2);
            Console.WriteLine(subSecond.Perform());
            Console.WriteLine("");
            Console.WriteLine("-----------Multiply-------------");
            var multOne = new Multiply(6, 2);
            var multSecond = new Multiply(multOne.Perform(), 2);
            Console.WriteLine(multSecond.Perform());
            Console.WriteLine("");
            Console.WriteLine("-----------Divide-------------");
            var dividetOne = new Divide(20, 2);
            var divideSecond = new Divide(dividetOne.Perform(), 2);
            Console.WriteLine(divideSecond.Perform());



            //var respSum = calculatorProgram.Sum(1, 2);
            //respSum = calculatorProgram.Sum(respSum, 8);
            //respSum = calculatorProgram.Sum(respSum, 9);

            //var respSubstract = calculatorProgram.Substract(4, 2);
            //var respMultiply = calculatorProgram.Multiply(3, 7);
            //var respDivide = calculatorProgram.Divide(3, 2);
        }
    }
}
