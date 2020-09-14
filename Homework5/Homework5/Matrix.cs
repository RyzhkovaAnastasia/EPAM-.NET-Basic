using System;

namespace Homework5
{
    public class Matrix
    {
        readonly int _rows;
        readonly int _columns;
        int[,] _matrix;

        public int Rows
        {
            get
            {
                return _rows;
            }

        }
        public int Columns
        {
            get
            {
                return _columns;
            }

        }
        public int this[int i, int j]
        {
            get
            {
                return _matrix[i, j];
            }


            set
            {
                _matrix[i, j] = value;
            }
        }

        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                InvalidMatrixSizesException exception = new InvalidMatrixSizesException(rows, columns);
            }

            _rows = rows;
            _columns = columns;

            try
            {
                _matrix = new int[rows, columns];
            }
            catch(OutOfMemoryException e)
            {
                throw new OutOfMemoryException(e.Message);
            }
        }
        public Matrix GetEmpty(int rows, int columns)
        {
            Matrix matrix = new Matrix(rows, columns);

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            return matrix;
        }

        public static Matrix operator+ (Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Columns || matrix1.Rows != matrix2.Rows)
            {
                throw new ArgumentException($"Matrices have different sizes", "matrix2");
            }

            Matrix resMatr = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < resMatr.Rows; i++) {
                for (int j = 0; j < resMatr.Columns; j++) {
                    try
                    {
                        checked
                        {
                            resMatr[i, j] = matrix1[i, j] + matrix2[i, j];
                        }
                    }
                    catch(OverflowException e)
                    {
                        throw new ArithmeticException(e.Message);
                    }
                }
            }
            return resMatr;
        }
        public static Matrix operator- (Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Columns || matrix1.Rows != matrix2.Rows)
            {
                throw new ArgumentException($"Matrices have different sizes", "matrix2");
            }

            Matrix resMatr = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < resMatr.Rows; i++)
            {
                for (int j = 0; j < resMatr.Columns; j++)
                {
                    try
                    {
                        checked
                        {
                            resMatr[i, j] = matrix1[i, j] - matrix2[i, j];
                        }
                    }
                    catch (OverflowException e)
                    {
                        throw new ArithmeticException(e.Message);
                    }
                }
            }
            return resMatr;
        }
        public static Matrix operator* (Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Columns != matrix2.Columns)
            {
                throw new ArgumentException($"Matrices have different column sizes", "matrix2");
            }

            Matrix resMatr = new Matrix(matrix1.Rows, matrix1.Columns);

            for (var i = 0; i < matrix1.Rows; i++)
            {
                for (var j = 0; j < matrix2.Columns; j++)
                {
                    for (var k = 0; k < matrix1.Columns; k++)
                    {
                        try
                        {
                            checked
                            {
                                resMatr[i, j] += matrix1[i, k] * matrix2[k, j];
                            }
                        }
                        catch (OverflowException e)
                        {
                            throw new ArithmeticException(e.Message);
                        }
                    }
                }
            }
                return resMatr;
        }
    }
}
