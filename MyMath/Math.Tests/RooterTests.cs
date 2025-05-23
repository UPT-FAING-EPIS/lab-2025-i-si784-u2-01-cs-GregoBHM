using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math.Lib;

namespace Math.Tests
{
    [TestClass]
    public class RooterTests
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            Rooter rooter = new Rooter();
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        public void SquareRootOfTwentyFive_IsFive()
        {
            Rooter rooter = new Rooter();
            double result = rooter.SquareRoot(25);
            Assert.AreEqual(5.0, result, delta: 0.01);
        }

        [TestMethod]
        public void RooterTestNegativeInput()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-10);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return; // Excepción esperada
            }
            Assert.Fail("Se esperaba ArgumentOutOfRangeException.");
        }

        [TestMethod]
        public void RooterTestNegativeInput_Alternate()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-25);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return; // También se espera esta excepción
            }
            Assert.Fail("Se esperaba ArgumentOutOfRangeException.");
        }

        [TestMethod]
        public void RooterTestInvalidInputMessage()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-5);
            }
            catch (System.ArgumentOutOfRangeException ex)
            {
                StringAssert.Contains(ex.Message, "El valor ingresado es invalido, solo se puede ingresar números positivos");
                return;
            }
            Assert.Fail("Se esperaba una excepción con mensaje personalizado.");
        }
    }
}
