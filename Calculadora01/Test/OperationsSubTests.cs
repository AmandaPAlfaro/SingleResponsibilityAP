using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora01.Test
{
    public class OperationsSubTests
    {
        [TestMethod]
        public void VerifySubstractOfPositiveNumbers()
        {
            var expectedSubstract = 2;
            var number1 = 4;
            var number2 = 2;

            var resultOfSubstract = new Substract(number1, number2).Perform();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }

        [TestMethod]
        public void VerifySubstractOfNegativeNumbers()
        {
            var expectedSubstract = -2;
            var number1 = -4;
            var number2 = -2;

            var resultOfSubstract = new Substract(number1, number2).Perform();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
        }

        [TestMethod]
        public void VerifyUndoOfSubstractOfPositiveNumbers()
        {
            var expectedSubstract = 6;
            var expectedUndo = 6;
            var number1 = 8;
            var number2 = 2;

            var substractToTest = new Substract(number1, number2);
            var resultOfSubstract = substractToTest.Perform();
            var resultOfUndo = substractToTest.Undo();

            Assert.AreEqual(expectedSubstract, resultOfSubstract, $"The Expected result of Substract should be {expectedSubstract} But it was: {resultOfSubstract}");
            Assert.AreEqual(expectedUndo, resultOfUndo, $"The Expected result of Undo in Substract should be {expectedUndo} But it was: {resultOfUndo}");
        }
    }
}
