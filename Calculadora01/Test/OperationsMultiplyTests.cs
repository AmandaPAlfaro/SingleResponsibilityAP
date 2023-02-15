using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora01.Test
{
    [TestClass]
    public class OperationsMultiplyTests
    {
        [TestMethod]
        public void VerifyMultiplyOfPositiveNumbers()
        {
            var expectedMultiply = 2;
            var firstNumber = 1;
            var secondNumber = 2;

            var resultOfMultiply = new Multiply(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedMultiply, resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
        }

        [TestMethod]
        public void VerifyMultiplyOfNegativeNumbers()
        {
            var expectedMultiply = 2;
            var firstNumber = -1;
            var secondNumber = -2;

            var resultOfMultiply = new Multiply(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedMultiply, resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
        }

        [TestMethod]
        public void VerifyUndoOfMultiplyOfPositiveNumbers()
        {
            var expectedUndo = 2;
            var expectedMultiply = 10;
            var firstNumber = 2;
            var secondNumber = 5;

            var multiplyToTest = new Multiply(firstNumber, secondNumber);
            var resultOfMultiply = multiplyToTest.Perform();
            var resultOfUndo = multiplyToTest.Undo();

            Assert.AreEqual(expectedMultiply, resultOfMultiply, $"The Expected result of Multiply should be {expectedMultiply} But it was: {resultOfMultiply}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Multiply should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }

}
