using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string input = "123.45";
            // Act
            double result = _inputConverter.ConvertToDouble(input);
            // Assert
            Assert.AreEqual(123.45, result);
        }
        public void TestMethod2()
        {
            // Arrange
            string input = "invalid";
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _inputConverter.ConvertToDouble(input));
        }
    }
}
