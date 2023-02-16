using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora01.Test
{
    [TestClass]
    public class OperationsDivideTests
    {
        [TestMethod]
        public void VerifyDivideOfPositiveNumbers()
        {
            var expectedDivide = 5;
            var firstNumber = 10;
            var secondNumber = 2;

            var resultOfDivide = new Divide(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
        }

        [TestMethod]
        public void VerifyDivideOfNegativeNumbers()
        {
            var expectedDivide = 5;
            var firstNumber = -10;
            var secondNumber = -2;

            var resultOfDivide = new Divide(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
        }

        [TestMethod]
        public void VerifyDivideOfNegativeAndPositiveNumbers()
        {
            var expectedDivide = -5;
            var firstNumber = 10;
            var secondNumber = -2;

            var resultOfDivide = new Divide(firstNumber, secondNumber).Perform();

            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
        }

        [TestMethod]
        public void VerifyUndoOfDivideOfPositiveNumbers()
        {
            var expectedUndo = 2;
            var expectedDivide = 5;
            var firstNumber = 10;
            var secondNumber = 2;

            var divideToTest = new Divide(firstNumber, secondNumber);
            var resultOfDivide = divideToTest.Perform();
            var resultOfUndo = divideToTest.Undo();

            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Divide should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
