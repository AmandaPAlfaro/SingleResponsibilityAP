using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora01.OperationDataDrive
{
    [TestClass]
    public class TestMultiplyDataDrive
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] {6, 4, 24},
                    new object[] {-4, -2, -8},
                    new object[] {-8, 2, -16},
                    new object[] {2, -4, -8},
                    new object[] {0, 8, 0},
                    new object[] {6, 0, 0},
                    new object[] {-7, 0, 0},
                    new object[] {0, -9, 0},
                    new object[] {0, 0, 0},
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifyMultiplyOfTwoIntegerNumber(int firstNumber, int secondNumber, int expectedMultiply)
        {

            var resultOfMultiply = new Multiply(firstNumber, secondNumber).Perform();
            Assert.AreEqual(expectedMultiply, resultOfMultiply, $"The Expected result of MultiplyTest should be {expectedMultiply} But it was: {resultOfMultiply}");
        }
    }
}
