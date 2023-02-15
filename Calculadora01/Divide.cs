namespace Calculadora01
{
    public class Divide
    {
        public int firstNumber;
        public int secondNumber;
        public int resultSum;

        public Divide(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            resultSum = (firstNumber / secondNumber);
            return resultSum;
        }

        public int Undo()
        {
            return resultSum * secondNumber;
        }
    }
}
