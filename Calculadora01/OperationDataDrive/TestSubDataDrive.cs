using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora01.OperationDataDrive
{
    [TestClass]
    public class TestSubDataDrive
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] {6, 4, 2},
                    new object[] {-4, -2, -2},
                    new object[] {-8, 3, -11},
                    new object[] {2, -4, -2},
                    new object[] {0, 8, 8},
                    new object[] {6, 0, 6},
                    new object[] {-7, 0, -7},
                    new object[] {0, -9, -9},
                    new object[] {0, 0, 0},

                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifySubstractOfTwoIntegerNumber(int firstNumber, int secondNumber, int expectedSum)
        {

            var resultOfSum = new Substract(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of SumTest should be {expectedSum} But it was: {resultOfSum}");
        }
    }
}
