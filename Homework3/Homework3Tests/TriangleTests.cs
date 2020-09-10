using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Homework3.Triangle;
namespace Homework3Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_Sides5_7_12_ShouldThrowException()
        {
            //Arrange
            double a = 5;
            double b = 7;
            double c = 12;
            //Act
            //Assert
            Assert.ThrowsException<System.Exception>(() => new Homework3.Triangle(a, b, c));
        }

        [TestMethod]
        public void Triangle_NegativeSides_ShouldThrowException()
        {
            //Arrange
            double a = -5;
            double b = -7;
            double c = -3;
            //Act
            //Assert
            Assert.ThrowsException<System.Exception>(() => new Homework3.Triangle(a, b, c));
        }

        [TestMethod]
        public void Triangle_ZeroSides_ShouldThrowException()
        {
            //Arrange
            double a = 0;
            double b = 0;
            double c = 0;
            //Act
            //Assert
            Assert.ThrowsException<System.Exception>(() => new Homework3.Triangle(a, b, c));
        }

        [TestMethod]
        public void Triangle_Sides4_3_5_ReturnNewObject()
        {
            //Arrange
            double a = 4;
            double b = 3;
            double c = 5;
            //Act
            var triangle = new Homework3.Triangle(a, b, c);
            //Assert
            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        public void Perimetr_Sides4_3_5_Return12()
        {
            //Arrange
            double a = 4;
            double b = 3;
            double c = 5;
            //Act
            var triangle = new Homework3.Triangle(a, b, c);
            double expectedResult = 12;
            double actualResult = triangle.Perimeter();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Square_Sides4_3_5_Return6()
        {
            //Arrange
            double a = 4;
            double b = 3;
            double c = 5;
            //Act
            var triangle = new Homework3.Triangle(a, b, c);
            double expectedResult = 6;
            double actualResult = triangle.Square();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
