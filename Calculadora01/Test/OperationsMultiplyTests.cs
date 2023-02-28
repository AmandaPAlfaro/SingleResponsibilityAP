using Calculadora01.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora01.Test
{
    [TestClass]
    public class OperationsMultiplyTests
    {
        public static IEnumerable<object[]> MultiplyData
        {
            get
            {
                return OperationMultiplication.GetMultiplicationData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(MultiplyData))]
        public void VerifySumOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedSum)
        {
            var resultOfSum = new Sum(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedSum), resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
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
