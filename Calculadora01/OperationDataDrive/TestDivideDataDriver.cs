using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculadora01.OperationDataDrive
{
    [TestClass]
    public class TestDivideDataDriver
    {
        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
                    new object[] {4, 2, 2},
                    new object[] {-8, -2, 4},
                    new object[] {-10, 2, -5},
                    new object[] {4, -2, -2},
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void VerifyDivideOfTwoIntegerNumber(int number1, int number2, int expectedDivide)
        {

            var resultOfDivide = new Divide(number1, number2).Perform();
            Assert.AreEqual(expectedDivide, resultOfDivide, $"The Expected result of DivideTest should be {expectedDivide} But it was: {resultOfDivide}");
        }
    }
}
