using Calculadora01.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora01.Test
{
    [TestClass]
    public class OperationsDivideTests
    {
        public static IEnumerable<object[]> DivideData
        {
            get
            {
                return OperationDivide.GetDivideData();
            }
        }

        [TestMethod]
        [DynamicData(nameof(DivideData))]
        public void VerifySumOfTwoIntegerNumbers(int id, string firstNumber, string secondNumber, string expectedSum)
        {
            var resultOfSum = new Sum(int.Parse(firstNumber), int.Parse(secondNumber)).Perform();
            Assert.AreEqual(int.Parse(expectedSum), resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
        }

        [TestMethod]
        public void VerifyUndoOfDivideOfPositiveNumbers()
        {
            var expectedUndo = 10;
            var expectedDivide = 5;
            var number1 = 10;
            var number2 = 2;

            var divideToTest = new Divide(number1, number2);
            var resultOfDivide = divideToTest.Perform();
            var resultOfUndo = divideToTest.Undo();

            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of Divide should be {expectedDivide} But it was: {resultOfDivide}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Divide should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
