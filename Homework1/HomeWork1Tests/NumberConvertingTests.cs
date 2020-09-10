using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Homework1.NumberConverting;

namespace RootCalculatorTests
{ 
    [TestClass]
    public class NumberConvertingTests
    {
        [TestMethod]
        public void ConvertDecimalToBinary_NegativeDecimalNumber_ShouldThrowFormatException()
        {
            // Arrange
            int number = -3125;
            // Act and Assert
            Assert.ThrowsException<System.FormatException>(() => ConvertDecimalToBinary(number));
        }

        [TestMethod]
        public void ConvertDecimalToBinary_DecimalNumber8_Return1111()
        {
            // Arrange
            int number = 8;
            // Act 
            string expectedResult = Convert.ToString(number, 2);
            string actualResult = ConvertDecimalToBinary(number);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
          
        }

        [TestMethod]
        public void ConvertDecimalToBinary_DecimalNumber245_Return11110101()
        {
            // Arrange
            int number = 245;
            // Act 
            string expectedResult = Convert.ToString(number, 2);
            string actualResult = ConvertDecimalToBinary(number);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
