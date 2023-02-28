using Calculadora01.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora01.Test
{
    [TestClass]
    public class OperationTestDB
    {
        public class OperationsTests
        {
            [TestMethod]
            public void VerifyUndoOfASumOfPositiveNumbers()
            {
                var expectedSum = 3;
                var expectedUndo = 1;
                var firstNumber = 1;
                var secondNumber = 2;

                var sumToTest = new Sum(firstNumber, secondNumber);
                var resultOfSum = sumToTest.Perform();
                var resultOfUndo = sumToTest.Undo();

                Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of Sum should be {expectedSum} But it was: {resultOfSum}");
                Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Sum should be {expectedUndo} But it was: {resultOfUndo}");
            }
        }
    }
}
