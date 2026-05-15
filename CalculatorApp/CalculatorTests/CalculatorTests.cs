using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Add(10, 5);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Subtract_ValidNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Subtract(10, 4);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Subtract_WhenALessThanB_ThrowsException()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act + Assert
            try
            {
                calculator.Subtract(2, 5);

                Assert.Fail();
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Multiply(3, 5);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Divide_ValidNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Divide(10, 2);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act + Assert
            try
            {
                calculator.Divide(10, 0);

                Assert.Fail();
            }
            catch (DivideByZeroException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            bool result = calculator.IsEven(4);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEven_OddNumber_ReturnsFalse()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            bool result = calculator.IsEven(5);

            // Assert
            Assert.IsFalse(result);
        }
    }
}