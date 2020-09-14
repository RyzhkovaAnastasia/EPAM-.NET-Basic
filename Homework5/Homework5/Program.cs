using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        delegate Matrix Operation(Matrix m1, Matrix m2);

        static Matrix SizeInitialization(string numOfMatrix)
        {
            int rows;
            int columns;

            Console.Write($"Enter row size for the {numOfMatrix} matrix: ");
            Int32.TryParse(Console.ReadLine(), out rows);
            Console.Write($"Enter columns size for the {numOfMatrix} matrix: ");
            Int32.TryParse(Console.ReadLine(), out columns);
            return new Matrix(rows, columns);
        }
        static Matrix EnteringMatrixSizes(string numOfMatrix, Matrix matrix)
        {
            try
            {
                matrix = SizeInitialization(numOfMatrix);
                return matrix;
               
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("ArgumentException: " + e.Message);
                Console.WriteLine("Try enter again");
                EnteringMatrixSizes(numOfMatrix, matrix);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return null;
        }
        static void SetMatrixValues(string numOfMatrix, Matrix matrix)
        {
            Console.WriteLine($"Enter values to the {numOfMatrix} matrix: ");
            for (int i = 0; i < matrix.Rows; i++)
            {
                for(int j = 0; j < matrix.Columns; j++)
                {
                    int value;
                    Console.Write($"Enter value to matrix [{i+1}][{j+1}]: ");
                    Int32.TryParse(Console.ReadLine(), out value);
                    matrix[i, j] = value;
                }
            }
        }

        static void Calculating(string calcName, Matrix matrix1, Matrix matrix2, Operation operation)
        {
            Console.WriteLine("Matrix 1 "+ calcName +" Matrix 2: ");
            try
            {
                PrintMatrix(operation(matrix1, matrix2));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write(matrix[i,j].ToString() + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Matrix matrix1 = null;
            Matrix matrix2 = null;
            Operation operation = null;

            Console.WriteLine("Matrix calculator");
            Console.WriteLine("Enter sizes of two matrices");
            matrix1 = EnteringMatrixSizes("first", matrix1);
            matrix2 = EnteringMatrixSizes("second", matrix2);
            Console.WriteLine("Enter values to matrices");
            SetMatrixValues("first", matrix1);
            SetMatrixValues("second", matrix2);


            operation += (m1, m2) => m1 + m2;
            Calculating("+", matrix1, matrix2, operation);
            operation -= (m1, m2) => m1 + m2;

            operation += (m1, m2) => m1 - m2;
            Calculating("-", matrix1, matrix2, operation);
            operation -= (m1, m2) => m1 - m2;

            operation += (m1, m2) => m1 * m2;
            Calculating("*", matrix1, matrix2, operation);
            operation -= (m1, m2) => m1 * m2;

            Console.ReadKey();
        }
    }
}
