namespace Calculadora01
{
    public class Multiply
    {
        public int number1;
        public int number2;
        public int result;

        public Multiply(int firstNumber, int secondNumber)
        {
            this.number1 = firstNumber;
            this.number2 = secondNumber;
        }

        public int Perform()
        {
            result = number1 * number2;
            return result;
        }
        public int Undo()
        {
            return result / number2;
        }
    }
}
