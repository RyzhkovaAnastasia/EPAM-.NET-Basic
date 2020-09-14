using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Homework5.Matrix;

namespace Homework5Tests
{
    [TestClass]
    public class MatrixTests
    {
        private void SetValuesToMatrix(Homework5.Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    matrix[i, j] = i + j;
                }
            }
        }

        private bool CheckSameMatrix(Homework5.Matrix matrix1, Homework5.Matrix matrix2)
        {
            if(matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)
            {
                return false;
            }

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    if(matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [TestMethod]
        public void Matrix_ValidSizes_ReturnNewObject()
        {
            //Arrange 
            int rows = 10;
            int columns = 5;
            //Act
            Homework5.Matrix matrix = new Homework5.Matrix(rows, columns);
            //Assert
            Assert.IsNotNull(matrix);
        }

        [TestMethod]
        public void Matrix_InvalidSizes_ShouldThrowArgumentException()
        {
            //Arrange 
            int rows = -10;
            int columns = 3;

            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Homework5.Matrix(rows, columns));
        }

        [TestMethod]
        public void GetEmpty_ValidSizes_ReturnZeroMatrix()
        {
            //Arrange 
            int rows = 10;
            int columns = 5;
            Homework5.Matrix matrix = new Homework5.Matrix(rows, columns);
            //Act
            var emptyMatrix = matrix.GetEmpty(rows, columns);
            //Assert
            Assert.IsNotNull(emptyMatrix);
        }

        [TestMethod]
        public void GetEmpty_InvalidSizes_ShouldThrowArgumentException()
        {
            //Arrange 
            int rows = -10;
            int columns = 3;

            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Homework5.Matrix(2, 2).GetEmpty(rows, columns));
        }

        [TestMethod]
        public void AdditionOperator_MatrixWithDifferentSizes_ShouldThrowArgumentException()
        {
            //Arrange 
            int matrixARows = 3;
            int matrixAColumns = 3;

            int matrixBRows = 4;
            int matrixBColumns = 4;

            var matrixA =  new Homework5.Matrix(matrixARows, matrixAColumns).GetEmpty(matrixARows, matrixAColumns);
            var matrixB = new Homework5.Matrix(matrixBRows, matrixBColumns).GetEmpty(matrixBRows, matrixBColumns);
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => matrixA + matrixB);
        }

        [TestMethod]
        public void AdditionOperator_MatrixWithSameSizes_ReturnNewMatrix()
        {
            //Arrange 
            int matrixARows = 2;
            int matrixAColumns = 2;

            int matrixBRows = 2;
            int matrixBColumns = 2;

            var matrixA = new Homework5.Matrix(matrixARows, matrixAColumns);
            var matrixB = new Homework5.Matrix(matrixBRows, matrixBColumns);

            SetValuesToMatrix(matrixA);
            SetValuesToMatrix(matrixB);

            var expectedResult = new Homework5.Matrix(matrixARows, matrixARows);
            expectedResult[0, 0] = 0;
            expectedResult[0, 1] = 2;
            expectedResult[1, 0] = 2;
            expectedResult[1, 1] = 4;
            //Act
            var actualResult = matrixA + matrixB;
            //Assert
            Assert.IsTrue(CheckSameMatrix(expectedResult, actualResult));
        }

        [TestMethod]
        public void AdditionOperator_MatrixWithOverflowValues_ShouldThrowArithmeticException()
        {
            //Arrange 
            int matrixARows = 1;
            int matrixAColumns = 1;

            int matrixBRows = 1;
            int matrixBColumns = 1;

            var matrixA = new Homework5.Matrix(matrixARows, matrixAColumns);
            var matrixB = new Homework5.Matrix(matrixBRows, matrixBColumns);
            matrixA[0, 0] = Int32.MaxValue - 5;
            matrixB[0, 0] = 10;
            
            //Act
            //Assert
            Assert.ThrowsException<ArithmeticException>(() => matrixA + matrixB);
        }

        [TestMethod]
        public void SubstractionOperator_MatrixWithDifferentSizes_ShouldThrowArgumentException()
        {
            //Arrange 
            int matrixARows = 3;
            int matrixAColumns = 3;

            int matrixBRows = 4;
            int matrixBColumns = 4;

            var matrixA = new Homework5.Matrix(matrixARows, matrixAColumns);
            var matrixB = new Homework5.Matrix(matrixBRows, matrixBColumns);
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => matrixA - matrixB);
        }

        [TestMethod]
        public void SubstractionOperator_MatrixWithSameSizes_ReturnNewMatrix()
        {
            //Arrange 
            int matrixARows = 2;
            int matrixAColumns = 2;

            int matrixBRows = 2;
            int matrixBColumns = 2;

            var matrixA = new Homework5.Matrix(matrixARows, matrixAColumns);
            var matrixB = new Homework5.Matrix(matrixBRows, matrixBColumns);

            SetValuesToMatrix(matrixA);
            SetValuesToMatrix(matrixB);

            var expectedResult = new Homework5.Matrix(matrixARows, matrixARows);
            expectedResult[0, 0] = 0;
            expectedResult[0, 1] = 0;
            expectedResult[1, 0] = 0;
            expectedResult[1, 1] = 0;
            //Act
            var actualResult = matrixA - matrixB;
            //Assert
            Assert.IsTrue(CheckSameMatrix(expectedResult, actualResult));
        }

        [TestMethod]
        public void SubstractionOperator_MatrixWithOverflowValues_ShouldThrowArithmeticException()
        {
            //Arrange 
            int matrixARows = 1;
            int matrixAColumns = 1;

            int matrixBRows = 1;
            int matrixBColumns = 1;

            var matrixA = new Homework5.Matrix(matrixARows, matrixAColumns);
            var matrixB = new Homework5.Matrix(matrixBRows, matrixBColumns);
            matrixA[0, 0] = Int32.MinValue + 5;
            matrixB[0, 0] = 10;
            //Act
            //Assert
            Assert.ThrowsException<ArithmeticException>(() => matrixA - matrixB);
        }


        [TestMethod]
        public void MultiplicationOperator_MatrixWithDifferentSizes_ShouldThrowArgumentException()
        {
            //Arrange 
            int matrixARows = 3;
            int matrixAColumns = 3;

            int matrixBRows = 3;
            int matrixBColumns = 4;

            var matrixA = new Homework5.Matrix(matrixARows, matrixAColumns);
            var matrixB = new Homework5.Matrix(matrixBRows, matrixBColumns);
            //Act
            //Assert
            Assert.ThrowsException<ArgumentException>(() => matrixA * matrixB);
        }

        [TestMethod]
        public void MultiplicationOperator_MatrixWithSameSizes_ReturnNewMatrix()
        {
            //Arrange 
            int matrixARows = 2;
            int matrixAColumns = 2;

            int matrixBRows = 2;
            int matrixBColumns = 2;

            var matrixA = new Homework5.Matrix(matrixARows, matrixAColumns);
            var matrixB = new Homework5.Matrix(matrixBRows, matrixBColumns);

            SetValuesToMatrix(matrixA);
            SetValuesToMatrix(matrixB);

            var expectedResult = new Homework5.Matrix(matrixARows, matrixARows);
            expectedResult[0, 0] = 1;
            expectedResult[0, 1] = 2;
            expectedResult[1, 0] = 2;
            expectedResult[1, 1] = 5;
            //Act
            var actualResult = matrixA * matrixB;
            //Assert
            Assert.IsTrue(CheckSameMatrix(expectedResult, actualResult));
        }

        [TestMethod]
        public void MultiplicationOperator_MatrixWithOverflowValues_ShouldThrowArithmeticException()
        {
            //Arrange 
            int matrixARows = 1;
            int matrixAColumns = 1;

            int matrixBRows = 1;
            int matrixBColumns = 1;

            var matrixA = new Homework5.Matrix(matrixARows, matrixAColumns);
            var matrixB = new Homework5.Matrix(matrixBRows, matrixBColumns);
            matrixA[0, 0] = Int32.MinValue;
            matrixB[0, 0] = 10;
            //Act
            //Assert
            Assert.ThrowsException<ArithmeticException>(() => matrixA * matrixB);
        }
    }
}
