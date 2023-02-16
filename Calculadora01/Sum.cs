namespace Calculadora01
{
    public class Sum
    {
        public int firstNumber;
        public int secondNumber;
        public int result;

        public Sum(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Perform()
        {
            result = firstNumber + secondNumber;
            return result;
        }

        public int Undo()
        {
            return result - secondNumber;
        }
    }
}
