using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            double firstNumber = 10;
            double secondNumber = 5;
            string operation = "add";
            // Act
            double result = _calculatorEngine.Calculate(firstNumber, secondNumber, operation);
            // Assert
            Assert.AreEqual(15, result);
        }
        public void TestMethod2()
        {
            // Arrange
            double firstNumber = 10;
            double secondNumber = 5;
            string operation = "-";
            // Act
            double result = _calculatorEngine.Calculate(firstNumber, secondNumber, operation);
            // Assert
            Assert.AreEqual(5, result);
        }
    }
}
