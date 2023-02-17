using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora01.Test
{
    [TestClass]
    public class OperationTests
    {
        [TestMethod]
        public void VerifySumOfPositiveNumbers()
        {
            var expectedSum = 3;
            var number1 = 1;
            var number2 = 2;

            var resultOfSum = new Sum(number1, number2).Perform();

            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
        }

        [TestMethod]
        public void VerifySumOfNegativeNumbers()
        {
            var expectedSum = -3;
            var number1 = -1;
            var number2 = -2;

            var resultOfSum = new Sum(number1, number2).Perform();

            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
        }

        [TestMethod]
        public void VerifyUndoOfSumOfPositiveNumbers()
        {
            var expectedSum = 3;
            var number1 = 1;
            var expectedUndo = 1;
            var number2 = 2;

            var sumToTest = new Sum(number1, number2);
            var resultOfSum = sumToTest.Perform();
            var resultOfUndo = sumToTest.Undo();

            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Sum should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
