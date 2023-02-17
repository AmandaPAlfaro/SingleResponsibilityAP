using System;

namespace Calculadora01
{
    public class CalculatorProgram
    {
        public int Sum(int number1, int number2) 
        {
            return number1 + number2;   
        }
        public int Substract(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Divide(int number1, int number2)
        {
            return number1  / number2;
        }

        static void Main(string[] args)
        {
            var calculatorProgram = new CalculatorProgram();

            var firstSum = new Sum(1, 2);
            var secondSum = new Sum(firstSum.Perform(), 8);
            var sumThird = new Sum(secondSum.Perform(), 9);
            Console.WriteLine(sumThird.Perform());
            var resultAfterUndo = sumThird.Undo();

            Console.WriteLine("------------------------");
            Console.WriteLine(resultAfterUndo);
            Console.WriteLine("------------------------");
            Console.WriteLine("");
            Console.WriteLine("-----------Substract-------------");
            var firstSubstract = new Substract(10, 2);
            var secondSubstract= new Substract(firstSubstract.Perform(), 2);
            Console.WriteLine(secondSubstract.Perform());

            Console.WriteLine("");
            Console.WriteLine("-----------Multiply-------------");
            var firstMultiply = new Multiply(6, 2);
            var secondMultiply = new Multiply(firstMultiply.Perform(), 2);
            Console.WriteLine(secondMultiply.Perform());

            Console.WriteLine("");
            Console.WriteLine("-----------Divide-------------");
            var firstDivide = new Divide(20, 2);
            var SecondDivide = new Divide(firstDivide.Perform(), 2);
            Console.WriteLine(SecondDivide.Perform());



            var respSum = calculatorProgram.Sum(1, 2);
            respSum = calculatorProgram.Sum(respSum, 8);
            respSum = calculatorProgram.Sum(respSum, 9);

            var respSubstract = calculatorProgram.Substract(4, 2);
            var respMultiply = calculatorProgram.Multiply(3, 7);
            var respDivide = calculatorProgram.Divide(3, 2);
        }
    }
}
