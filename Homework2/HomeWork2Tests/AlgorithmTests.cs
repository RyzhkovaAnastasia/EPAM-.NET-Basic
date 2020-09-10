using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Homework2.Algorithm;


namespace HomeWork2Tests
{
    [TestClass]
    public class AlgorithmTests
    {
        Homework2.Algorithm _algo = new Homework2.Algorithm();

        [TestMethod]
        public void EuclidianAlgorithm_GCD21and18_Result3()
        {
            //Arrange
            int number1 = 21;
            int number2 = 18;
            int expectedResult = 3;

            //Act
            int actualResult = _algo.EuclideanAlgorithm(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EuclidianAlgorithm_GCD21and100_Result1()
        {
            //Arrange
            int number1 = 21;
            int number2 = 100;
            int expectedResult = 1;

            //Act
            int actualResult = _algo.EuclideanAlgorithm(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EuclidianAlgorithm_GCD21and0_Result1()
        {
            //Arrange
            int number1 = 21;
            int number2 = 0;
            int expectedResult = 21;

            //Act
            int actualResult = _algo.EuclideanAlgorithm(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EuclidianAlgorithm_GCD0and0_ShouldThrowException()
        {
            //Arrange
            int number1 = 0;
            int number2 = 0;

            //Act
            //Assert
            Assert.ThrowsException<System.Exception>(() => _algo.EuclideanAlgorithm(number1, number2));
        }

        [TestMethod]
        public void EuclidianAlgorithm_GCDNegativeNumbers12And9_Result3()
        {
            //Arrange
            int number1 = -12;
            int number2 = -9;
            int expectedResult = 3;

            //Act
            int actualResult = _algo.EuclideanAlgorithm(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EuclidianAlgorithm_GCDSameNumbers12_Result12()
        {
            //Arrange
            int number1 = 12;
            int number2 = 12;
            int expectedResult = 12;

            //Act
            int actualResult = _algo.EuclideanAlgorithm(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EuclidianAlgorithm_GCDEvenCountOfNumbers12And3And9And18_Result3()
        {
            //Arrange
            int[] numbers = new int[] { 12, 3, 9, 18};
            
            int expectedResult = 3;

            //Act
            int actualResult = _algo.EuclideanAlgorithm(numbers);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EuclidianAlgorithm_GCDOddCountOfNumbers12And3And9_Result3()
        {
            //Arrange
            int[] numbers = new int[] { 12, 3, 9 };

            int expectedResult = 3;

            //Act
            int actualResult = _algo.EuclideanAlgorithm(numbers);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BinaryGCDAlgorithm_GCD21and9_Result3()
        {
            //Arrange
            int number1 = 2;
            int number2 = 22;
            int expectedResult = 2;

            //Act
            int actualResult = _algo.BinaryGCDAlgorithm(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BinaryGCDAlgorithm_GCD21and17_Result1()
        {
            //Arrange
            int number1 = 21;
            int number2 = 17;
            int expectedResult = 1;

            //Act
            int actualResult = _algo.BinaryGCDAlgorithm(number1, number2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BinaryGCDAlgorithm_GCD0and0_ShouldThrowException()
        {
            //Arrange
            int number1 = 0;
            int number2 = 0;

            //Act
            //Assert
            Assert.ThrowsException<System.Exception>(() => _algo.BinaryGCDAlgorithm(number1, number2));
        }
    }
}
