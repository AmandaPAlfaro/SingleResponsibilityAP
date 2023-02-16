namespace Calculadora01
{
    public class Divide
    {
        public int firstNumber;
        public int secondNumber;
        public int result;

        public Divide(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            result = (firstNumber / secondNumber);
            return result;
        }

        public int Undo()
        {
            return result * secondNumber;
        }
    }
}
