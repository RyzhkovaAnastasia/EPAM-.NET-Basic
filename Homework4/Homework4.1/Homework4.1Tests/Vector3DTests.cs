using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Homework4_1.Vector3D;
namespace Homework4_1Tests
{
    [TestClass]
    public class Vector3DTests
    {
        private bool Equal(Homework4_1.Vector3D v1, Homework4_1.Vector3D v2)
        {
            if( v1.X == v2.X &&
                v1.Y == v2.Y &&
                v1.Z == v2.Z){
                return true;
            }
            return false;
        }

        [TestMethod]
        public void AdditionOperator_Vector1_2_3_Vector_2_3_4_ReturnVector_3_5_7()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(1, 2, 3);
            Homework4_1.Vector3D vector2 = new Homework4_1.Vector3D(2, 3, 4);

            Homework4_1.Vector3D expectedVector = new Homework4_1.Vector3D(3, 5, 7);

            //Act
            var actualVector = vector1 + vector2;

            //Assert
            Assert.IsTrue(Equal(expectedVector, actualVector));
        }

        [TestMethod]
        public void SubstractionOperator_Vector1_2_3_Vector_2_3_4_ReturnVector_minus1_minus1_minus1()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(1, 2, 3);
            Homework4_1.Vector3D vector2 = new Homework4_1.Vector3D(2, 3, 4);

            Homework4_1.Vector3D expectedVector = new Homework4_1.Vector3D(-1, -1, -1);

            //Act
            var actualVector = vector1 - vector2;

            //Assert
            Assert.IsTrue(Equal(expectedVector, actualVector));
        }

        [TestMethod]
        public void MultiplicationOperator_Vector1_2_3_Vector_2_3_4_Return20()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(1, 2, 3);
            Homework4_1.Vector3D vector2 = new Homework4_1.Vector3D(2, 3, 4);

            double expectedResult = 20;

            //Act
            var actualResult = vector1 * vector2;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ModuloOperator_Vector1_2_3_Vector_2_3_4_ReturnVector_minus1_2_minus1()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(1, 2, 3);
            Homework4_1.Vector3D vector2 = new Homework4_1.Vector3D(2, 3, 4);

            Homework4_1.Vector3D expectedVector = new Homework4_1.Vector3D(-1, 2, -1);

            //Act
            var actualVector = vector1 % vector2;

            //Assert
            Assert.IsTrue(Equal(expectedVector, actualVector));
        }

        [TestMethod]
        public void ToString_Vector1_2_3_ReturnFormatString()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(1, 2, 3);

            string expectedResult = "x: 1, y: 2, z: 3";

            //Act
            var actualResualt = vector1.ToString();

            //Assert
            Assert.AreEqual(expectedResult, actualResualt);
        }

        [TestMethod]
        public void AdditionOperator_Vector1_2_3_Term3_ReturnVector_3_5_7()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(1, 2, 3);
            double term = 3;

            Homework4_1.Vector3D expectedVector = new Homework4_1.Vector3D(4, 5, 6);

            //Act
            var actualVector = vector1 + term;

            //Assert
            Assert.IsTrue(Equal(expectedVector, actualVector));
        }

        [TestMethod]
        public void AdditionOperatorTerm3__Vector1_2_3_ReturnVector_3_5_7()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(1, 2, 3);
            double term = 3;

            Homework4_1.Vector3D expectedVector = new Homework4_1.Vector3D(4, 5, 6);

            //Act
            var actualVector = term + vector1;

            //Assert
            Assert.IsTrue(Equal(expectedVector, actualVector));
        }

        [TestMethod]
        public void SubstractionOperator_Vector10_20_30_Term10_ReturnVector_0_10_20()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(10, 20, 30);
            double term = 10;

            Homework4_1.Vector3D expectedVector = new Homework4_1.Vector3D(0, 10, 20);

            //Act
            var actualVector = vector1 - term;

            //Assert
            Assert.IsTrue(Equal(expectedVector, actualVector));
        }

        [TestMethod]
        public void DevisionOperator_Vector10_20_30_Term10_ReturnVector_1_2_3()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(10, 20, 30);
            double term = 10;

            Homework4_1.Vector3D expectedVector = new Homework4_1.Vector3D(1, 2, 3);

            //Act
            var actualVector = vector1 / term;

            //Assert
            Assert.IsTrue(Equal(expectedVector, actualVector));
        }

        [TestMethod]
        public void MultiplicationOperator_Vector10_20_30_Term10_ReturnVector_100_200_300()
        {
            //Arrange
            Homework4_1.Vector3D vector1 = new Homework4_1.Vector3D(10, 20, 30);
            double term = 10;

            Homework4_1.Vector3D expectedVector = new Homework4_1.Vector3D(100, 200, 300);

            //Act
            var actualVector = vector1 * term;

            //Assert
            Assert.IsTrue(Equal(expectedVector, actualVector));
        }
    }
}
