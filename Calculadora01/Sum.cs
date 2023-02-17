namespace Calculadora01
{
    public class Sum
    {
        public int number1;
        public int number2;
        public int result;

        public Sum(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public int Perform()
        {
            result = number1 + number2;
            return result;
        }

        public int Undo()
        {
            return result - number2;
        }
    }
}
