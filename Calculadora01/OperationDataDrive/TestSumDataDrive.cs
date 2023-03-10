using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora01.OperationDataDrive
{
    [TestClass]
    public class TestSumDataDrive
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] {4, 6, 10},
                    new object[] {-2, -4, -6},
                    new object[] {-3, 8, 5},
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
        public void VerifySumOfTwoIntegerNumber(int number1, int number2, int expectedSum)
        {

            var resultOfSum = new Sum(number1, number2).Perform();
            Assert.AreEqual(expectedSum, resultOfSum, $"The Expected result of SumTest should be {expectedSum} But it was: {resultOfSum}");
        }
    }
}
