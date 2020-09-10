using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Homework1.RootCalculator;
using static System.Math;

namespace RootCalculatorTests
{
    [TestClass]
    public class RootCalculatorTests
    {
        [TestMethod]
        public void CalculateRootOfNumber_TheCubeRootsOf27_Result3()
        {
            // Arrange
            double number = 27;
            int power = 3;
            // Act
            double expectedResult = Pow(number, 1.0 / power);
            double actualResult = CalculateRootOfNumber(number, power);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateRootOfNumber_OddPowerRootWithNegativeNumber_NegativeRoot()
        {
            // Arrange
            double number = -3125;
            int power = 5;
            // Act
            double expectedResult = Pow(number, 1.0 / power);
            double actualResult = CalculateRootOfNumber(number, power);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CalculateRootOfNumber_EvenPowerRootWithNegativeNumber_ShouldThrowFormatException()
        {
            // Arrange
            double number = -3125;
            int power = 2;
            // Act and Assert
            Assert.ThrowsException<System.FormatException>(() => CalculateRootOfNumber(number, power));
        }

        [TestMethod]
        public void CalculateRootOfNumber_RootPowerIsNotNaturalNumber_ShouldThrowFormatException()
        {
            // Arrange
            double number = -3125;
            int power = -2;
            // Act and Assert
            Assert.ThrowsException<System.FormatException>(() => CalculateRootOfNumber(number, power));
        }
    }
}
