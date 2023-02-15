namespace Calculadora01
{
    public class Multiply
    {
        public int firstNumber;
        public int secondNumber;
        public int resultSum;

        public Multiply(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            resultSum = firstNumber * secondNumber;
            return resultSum;
        }
        public int Undo()
        {
            return resultSum / secondNumber;
        }
    }
}
